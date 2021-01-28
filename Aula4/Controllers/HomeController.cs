using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Aula4.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace Aula4.Controllers
{
    //[Authorize] autorizacao para tudo
    public class HomeController : Controller
    {
        // private readonly ILogger<HomeController> _logger;

        // public HomeController(ILogger<HomeController> logger)
        // {
        //     _logger = logger;
        // }
        
        private readonly UserManager<IdentityUser> _userManager;

        public HomeController( UserManager<IdentityUser> userManager){
                _userManager = userManager;
            }

        public async Task<IActionResult> Index() //foi transformado em codigo assincrinico
        {
            var user = await _userManager.GetUserAsync(User);
            //return Content(User.FindFirst("fullname").Value);
            //return Content(user.Email);
            return View();
        }

        //[Authorize] //autorizacao para apenas essa action
        [Authorize(Policy = "TemNome")] //autorizacao para apenas essa action

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
