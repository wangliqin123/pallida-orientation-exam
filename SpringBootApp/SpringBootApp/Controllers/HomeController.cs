using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SpringBootApp.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("/search")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
