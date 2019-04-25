using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using KonBase.Areas.Identity.Services;
using KonBase.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using NToastNotify;

namespace KonBase.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        private readonly IToastNotification _toastNotification;
        private readonly SignInManager<ApplicationUsers> _signInManager;
        private readonly UserManager<ApplicationUsers> _userManager;
        private readonly ILogger<RegisterModel> _logger;
        private readonly EmailSender _emailSender;

        public RegisterModel(
            UserManager<ApplicationUsers> userManager,
            SignInManager<ApplicationUsers> signInManager,
            ILogger<RegisterModel> logger,
            EmailSender emailSender,
            IToastNotification toastNotification)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
            _toastNotification = toastNotification;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public string ReturnUrl { get; set; }

        [TempData]
        public string ErrorMessage { get; set; }

        public class InputModel
        {
            [Required(ErrorMessage = "Nome é um campo obrigatório", AllowEmptyStrings = false)]
            [StringLength(100, ErrorMessage = "O {0} deve ter pelo menos {2} e no máximo {1} caracteres.", MinimumLength = 3)]
            [Display(Name = "Nome")]
            public string FirstName { get; set; }

            [Required(ErrorMessage = "Sobrenome é um campo obrigatório", AllowEmptyStrings = false)]
            [StringLength(100, ErrorMessage = "O {0} deve ter pelo menos {2} e no máximo {1} caracteres.", MinimumLength = 3)]
            [Display(Name = "Sobrenome")]
            public string LastName { get; set; }

            [Required(ErrorMessage = "Telefone é um campo obrigatório", AllowEmptyStrings = false)]
            [RegularExpression(@"^\([1-9]{2}\) [2-9][0-9]{3,4}\-[0-9]{4}$", ErrorMessage = "Celular está em um formato inválido.")]
            [Display(Name = "Celular")]
            public string CellPhone { get; set; }

            [Required(ErrorMessage = "Email é um campo obrigatório")]
            [RegularExpression(@"^(([A-Za-z0-9]+_+)|([A-Za-z0-9]+\-+)|([A-Za-z0-9]+\.+)|([A-Za-z0-9]+\++))*[A-Za-z0-9]+@((\w+\-+)|(\w+\.))*\w{1,63}\.[a-zA-Z]{2,6}$", ErrorMessage = "Email está em um formato inválido.")]
            public string Email { get; set; }

            [Required(ErrorMessage = "Senha é um campo obrigatório", AllowEmptyStrings = false)]
            [DataType(DataType.Password)]
            [Display(Name = "Senha")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirmar Senha")]
            [Compare("Password", ErrorMessage = "As senhas não correspondem.")]
            public string ConfirmPassword { get; set; }


            [Required(ErrorMessage = "Para poder usar o Konbase você deve aceitar a Política de Privacidade")]
            public bool PrivacyPolicy { get; set; }
        }

        public async Task OnGet(string returnUrl = null)
        {
            if (!string.IsNullOrEmpty(ErrorMessage))
            {
                ModelState.AddModelError(string.Empty, ErrorMessage);
            }

            returnUrl = returnUrl ?? Url.Content("~/");

            // Limpe o cookie externo existente para garantir um processo de registro limpo
            await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);

            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

            ReturnUrl = returnUrl;
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");
            if (ModelState.IsValid)
            {
                var user = new ApplicationUsers {
                    UserName = Input.Email,
                    Email = Input.Email,
                    FirstName = Input.FirstName,
                    LastName = Input.LastName,
                    PhoneNumber = Input.CellPhone
                };

                var result = await _userManager.CreateAsync(user, Input.Password);
                if (result.Succeeded)
                {
                    _logger.LogInformation("O usuário criou uma nova conta com senha");

                    var codeGerado = await _userManager.GenerateEmailConfirmationTokenAsync(user);

                    var callbackUrl = Url.Page("/Account/ConfirmEmail",pageHandler: null,values: new { userId = user.Id, code = codeGerado },protocol: Request.Scheme);

                    await _emailSender.SendEmail(Input.Email, "Confirme seu Email", "d-06e3c2ffdd3e4b9ca167309726a718b8", callbackUrl);

                    await _signInManager.SignInAsync(user, isPersistent: false);

                    _toastNotification.AddSuccessToastMessage("Obrigado por se registrar. Confirme seu Email para poder entrar.");

                    return RedirectToPage("./Login");
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            _toastNotification.AddWarningToastMessage("Alguma informação foi digitada incorretamente.");
            // Se chegamos até aqui, algo falhou, formulário de reexame
            return Page();
        }
    }
}
