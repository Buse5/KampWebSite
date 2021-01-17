using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proje.Controllers
{
    public class Sehirler : Controller
    {
        public IActionResult Bolu()
        {
            return View();
        }
        public IActionResult Mugla()
        {
            return View();
        }
    }
}
