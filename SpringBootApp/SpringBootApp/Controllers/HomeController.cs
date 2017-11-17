﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpringBootApp.Services;

namespace SpringBootApp.Controllers
{
    [Route("search")]
    public class HomeController : Controller
    {
        SpringBootAppService SpringBootAppService;

        public HomeController(SpringBootAppService springBootAppService)
        {
            SpringBootAppService = springBootAppService;
        }

        [HttpGet]
        [Route("/{inputPlate}")]
        public IActionResult Index([FromQuery] string inputPlate)
        {
            if (ModelState.IsValid)
            {
                return View(SpringBootAppService.GetLicencePlateListForUser(inputPlate));
            }
            return View();
        }

        [HttpGet]
        [Route("/{brand}/search")]
        public IActionResult Brand([FromRoute] string inputBrand)
        {
            //SpringBootAppService.GetBrandListForUser(inputBrand);
            //return LocalRedirect("index");
            return View(SpringBootAppService.GetBrandListForUser(inputBrand));
        }

        [HttpGet]
        [Route("api/search/{brand}")]
        public IActionResult BrandListJson([FromBody] string inputBrand)
        {
            return Json(SpringBootAppService.GetBrandListForUser(inputBrand));
        }
    }
}
