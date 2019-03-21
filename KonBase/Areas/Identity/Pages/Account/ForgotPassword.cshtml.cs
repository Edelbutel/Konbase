using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using KonBase.Areas.Identity.Services;
using KonBase.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NToastNotify;

namespace KonBase.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class ForgotPasswordModel : PageModel
    {
        private readonly IToastNotification _toastNotification;
        private readonly UserManager<ApplicationUsers> _userManager;
        private readonly EmailSender _emailSender;

        public ForgotPasswordModel(UserManager<ApplicationUsers> userManager, EmailSender emailSender, IToastNotification toastNotification)
        {
            _userManager = userManager;
            _emailSender = emailSender;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            [Required(ErrorMessage = "Email é um campo obrigatório")]
            [RegularExpression(@"^(([A-Za-z0-9]+_+)|([A-Za-z0-9]+\-+)|([A-Za-z0-9]+\.+)|([A-Za-z0-9]+\++))*[A-Za-z0-9]+@((\w+\-+)|(\w+\.))*\w{1,63}\.[a-zA-Z]{2,6}$", ErrorMessage = "Email está em um formato inválido.")]
            public string Email { get; set; }
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(Input.Email);
                if (user == null || !(await _userManager.IsEmailConfirmedAsync(user)))
                {
                    // Não revele que o usuário não existe ou não está confirmado
                    return RedirectToPage("./ForgotPasswordConfirmation");
                }

                var codeGerado = await _userManager.GenerateEmailConfirmationTokenAsync(user);

                var callbackUrl = Url.Page("/Account/ResetPassword", pageHandler: null, values: new { userId = user.Id, code = codeGerado }, protocol: Request.Scheme);

                await _emailSender.SendEmail(Input.Email, "Confirme seu Email", "d-fd9d7b96fc9440e7a946026e2f7904a0", callbackUrl);

                _toastNotification.AddWarningToastMessage("Verefique seu Email para poder recuperar a senha.");

                return RedirectToPage("./Login");
            }

            return Page();
        }
    }
}
