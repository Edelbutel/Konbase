using KonBase.Areas.Admin.Interfaces;
using KonBase.Areas.Admin.Models;
using KonBase.Areas.Admin.Models.ApplicationCondominiumViewModels;
using KonBase.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace KonBase.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class CondominiumController : Controller
    {
        private readonly UserManager<ApplicationUsers> _userManager;
        private readonly ICondominiumService _condominiumManager;
        private readonly IToastNotification _toastNotification;

        public CondominiumController(
            UserManager<ApplicationUsers> userManager,
            ICondominiumService condominiumManager,
            IToastNotification toastNotification)
        {
            _condominiumManager = condominiumManager;
            _userManager = userManager;
            _toastNotification = toastNotification;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(User);

            if (user == null)
            {
                throw new ApplicationException($"Não é possível carregar o usuário com o ID '{_userManager.GetUserId(User)}'.");
            }

            var model = await _condominiumManager.GetAllCondominiumAsync(user.Id);

            return View(model);
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Add(string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;

            AddCondominiumViewModel model = new AddCondominiumViewModel();

            model.Phones.Add(null);
            model.Emails.Add(null);

            return View(model);
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add(AddCondominiumViewModel model, string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;

            int contPhone = 0;
            int contEmail = 0;

            model.Phones = model.Phones.Where(x => x != null && x.Phone != null).GroupBy(x => x.Phone).Select(y => y.First()).ToList();
            model.Emails = model.Emails.Where(x => x != null && x.Email != null).GroupBy(x => x.Email).Select(y => y.First()).ToList();

            Regex regexPhone = new Regex(@"^\([1-9]{2}\) (?:[2-8]|9[1-9])[0-9]{3}\-[0-9]{4}$");
            Regex regexEmail = new Regex(@"^(([A-Za-z0-9]+_+)|([A-Za-z0-9]+\-+)|([A-Za-z0-9]+\.+)|([A-Za-z0-9]+\++))*[A-Za-z0-9]+@((\w+\-+)|(\w+\.))*\w{1,63}\.[a-zA-Z]{2,6}$");

            foreach (var Phone in model.Phones.ToList().Select((value, index) => new { value, index }))
            {
                if (!regexPhone.IsMatch(Phone.value.Phone))
                {
                    model.Phones.RemoveAt(Phone.index - contPhone);

                    contPhone++;
                }
            }

            foreach (var Email in model.Emails.ToList().Select((value, index) => new { value, index }))
            {
                if (!regexPhone.IsMatch(Email.value.Email))
                {
                    model.Emails.RemoveAt(Email.index - contEmail);

                    contEmail++;
                }
            }


            if (ModelState.IsValid)
            {
                var user = await _userManager.GetUserAsync(User);

                if (user == null)
                {
                    throw new ApplicationException($"Não é possível carregar o usuário com o ID '{_userManager.GetUserId(User)}'.");
                }

                var checkCNPJ = await _condominiumManager.CheckCNPJAsync(model.Cnpj);

                if (checkCNPJ == null)
                {
                    var condominium = new ApplicationCondominium
                    {
                        CompanyName = model.CompanyName,
                        FantasyName = model.FantasyName,
                        Cnpj = model.Cnpj,
                        ConstructionDate = model.ConstructionDate,
                        CondominiumType = model.CondominiumType,
                        Cep = model.Cep,
                        Address = model.Address,
                        City = model.City,
                        District = model.District,
                        Uf = model.Uf,
                        Number = model.Number,
                        Complement = model.Complement,
                        Note = model.Note,
                        User = user
                    };

                    var verify = await _condominiumManager.CreateCondominiumAsync(condominium);

                    if (verify != null)
                    {
                        foreach (var Phone in model.Phones)
                        {
                            var condominiumPhone = new ApplicationCondominiumPhone
                            {
                                Phone = Phone.Phone,
                                Condominium = condominium
                            };

                            await _condominiumManager.CreateCondominiumPhoneAsync(condominiumPhone);
                        }

                        foreach (var Email in model.Emails)
                        {
                            var condominiumEmail = new ApplicationCondominiumEmail
                            {
                                Email = Email.Email,
                                Condominium = condominium
                            };

                            await _condominiumManager.CreateCondominiumEmailAsync(condominiumEmail);
                        }

                        _toastNotification.AddSuccessToastMessage("Condomínio cadastrado com sucesso.");

                        return RedirectToAction("Index");
                    }

                }
            
                _toastNotification.AddErrorToastMessage("Já existe um condomínio cadastrado com esse CNPJ.");

                return View(model);
            }

            return View(model);
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Edit(long Id)
        {

            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(AddCondominiumViewModel model, string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;

            return View(model);
        }

        public PartialViewResult AddPhone()
        {
            var phone = new PhoneViewModel();

            return PartialView("_PhoneMinus", phone);
        }

        public PartialViewResult AddEmail()
        {
            var email = new EmailViewModel();

            return PartialView("_EmailMinus", email);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new Models.ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
