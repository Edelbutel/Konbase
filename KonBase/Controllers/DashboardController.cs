﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using KonBase.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using KonBase.Services.Interfaces;

namespace KonBase.Controllers
{
    [Authorize]
    [Route("[controller]/[action]")]
    public class DashboardController : Controller
    {
        private readonly UserManager<ApplicationUsers> _userManager;
        private readonly ICondominiumService _condominiumManager;

        public DashboardController(
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
    }
}
