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
        [Route("/{inputPlate}/{police}/{diplomat}")]
        public IActionResult Index([FromQuery] string inputPlate, string police, string diplomat)
        {
            if ([FromQueryAttribute] == police)
            {
                return View(SpringBootAppService.GetLicencePlateListForUser(inputPlate));
            }
            return View();
        }

        [HttpGet]
        [Route("/{brand}/search")]
        public IActionResult Brand([FromRoute] string inputBrand)
        {
            SpringBootAppService.GetBrandListForUser(inputBrand);
            return LocalRedirect("index");
        }
    }
}