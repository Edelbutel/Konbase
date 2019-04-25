using KonBase.Models;
using KonBase.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KonBase.Controllers
{
    [Authorize]
    [Route("[controller]/[action]")]
    public class CondominiumController : Controller
    {
        private readonly UserManager<ApplicationUsers> _userManager;
        private readonly ICondominiumService _condominiumManager;

        public CondominiumController(
            UserManager<ApplicationUsers> userManager,
            ICondominiumService condominiumManager)
        {
            _condominiumManager = condominiumManager;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {

            return View();
        }

    }
}
