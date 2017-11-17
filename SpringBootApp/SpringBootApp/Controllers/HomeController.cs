using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpringBootApp.Services;

namespace SpringBootApp.Controllers
{
    public class HomeController : Controller
    {
        SpringBootAppService SpringBootAppService;

        public HomeController(SpringBootAppService springBootAppService)
        {
            SpringBootAppService = springBootAppService;
        }

        [HttpGet]
        [Route("/search")]
        public IActionResult Index(string inputPlate)
        {
            return View(SpringBootAppService.GetLicencePlateListForUser(inputPlate));
        }
    }
}
