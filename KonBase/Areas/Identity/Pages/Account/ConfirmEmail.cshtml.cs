using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KonBase.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NToastNotify;

namespace KonBase.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class ConfirmEmailModel : PageModel
    {
        private readonly IToastNotification _toastNotification;
        private readonly UserManager<ApplicationUsers> _userManager;

        public ConfirmEmailModel(UserManager<ApplicationUsers> userManager, IToastNotification toastNotification)
        {
            _toastNotification = toastNotification;
            _userManager = userManager;
        }

        public async Task<IActionResult> OnGetAsync(string userId, string code)
        {
            if (userId == null || code == null)
            {
                return RedirectToPage("/Index");
            }

            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return NotFound($"Não é possível carregar o usuário com o ID '{userId}'.");
            }

            var result = await _userManager.ConfirmEmailAsync(user, code);
            if (!result.Succeeded)
            {
                throw new InvalidOperationException($"Erro ao confirmar email para usuário com ID '{userId}':");
            }

            _toastNotification.AddSuccessToastMessage("Obrigado por confirmar seu Email");

            return RedirectToAction("Login", "Account");
        }
    }
}
