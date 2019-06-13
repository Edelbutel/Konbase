using KonBase.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KonBase.Controllers
{
    public class RedirectController : Controller
    {
        private readonly UserManager<ApplicationUsers> _userManager;
        private readonly IToastNotification _toastNotification;

        public RedirectController(
            UserManager<ApplicationUsers> userManager,
            IToastNotification toastNotification)
        {
            _userManager = userManager;
            _toastNotification = toastNotification;
        }
        public async Task<IActionResult> RedirectUserLoginAsync()
        {
            _toastNotification.AddSuccessToastMessage("Você entrou com sucesso");

            var user = await _userManager.GetUserAsync(User);

            var userRole = await _userManager.GetRolesAsync(user);

            if (userRole[0] == "Dweller")
            {
                return RedirectToAction("Index", "Dashboard", new { area = "Dweller" });
            }
            else if (userRole[0] == "Concierge")
            {
                return RedirectToAction("Index", "Dashboard", new { area = "Concierge" });
            }
            else
            {
                return RedirectToAction("Index", "Dashboard", new { area = "Admin" });
            }
        }

        [HttpPost]
        public async Task<IActionResult> RedirectUserAsync()
        {
            var user = await _userManager.GetUserAsync(User);

            var userRole = await _userManager.GetRolesAsync(user);

            if (userRole[0] == "Dweller")
            {
                return RedirectToAction("Index", "Dashboard", new { area = "Dweller" });
            }
            else if (userRole[0] == "Concierge")
            {
                return RedirectToAction("Index", "Dashboard", new { area = "Concierge" });
            }
            else
            {
                return RedirectToAction("Index", "Dashboard", new { area = "Admin" });
            }
        }

    }
}
