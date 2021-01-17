using LoginData.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Proje.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Proje.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Hakkimda()
        {
            return View();
        }
        public IActionResult Oneriler()
        {
            return View();
        }
        public IActionResult Iletisim()
        {
            return View();
        }
        
        public IActionResult Login()
        { 
            return View("~/Views/Home/Login.cshtml"); 
        }
        public IActionResult Kayit()
        {
            return View("~/Views/Home/Kayit.cshtml");
        }
        [HttpPost]
        public IActionResult Login(Models.Login data)
        {
            LoginData.Services.UserServices servis = new LoginData.Services.UserServices();
            var result=servis.Login(data.userName, data.password);
            if (result) 
            {        
                    return View("~/Views/Home/Index.cshtml");               
            }
            return View("~/Views/Home/Login.cshtml");

        }
        [HttpPost]
        public IActionResult Kayit(LoginData.Models.Registration data)
        {
            //LoginData.Services.UserServices services = new LoginData.Services.UserServices();
            //var result = services.Save(data);
            //if (result>0) 
            //{
            //    return RedirectToAction("Edit", new { Id=result});
            //}
            return View();
            

        }

        public IActionResult Cikis()
        {
            return View("~/Views/Home/Login.cshtml");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
