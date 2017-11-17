using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpringBootApp.Services;


namespace SpringBootApp.Controllers
{
    public class RestController : Controller
    {
        SpringBootAppService SpringBootAppService;

        public RestController(SpringBootAppService springBootAppService)
        {
            SpringBootAppService = springBootAppService;
        }

        [HttpGet]
        [Route("api/search/{inputBrand}")]
        public IActionResult BrandListJson(string inputBrand)
        {
            return Json(SpringBootAppService.GetBrandListForUser(inputBrand));
        }
    }
}
