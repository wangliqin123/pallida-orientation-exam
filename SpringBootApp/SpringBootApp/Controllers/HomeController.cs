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
        [Route("/{police}")]
        [Route("/{diplomat}")]
        public IActionResult Index([FromQuery] string inputPlate, string police, string diplomat)
        {
            if (RouteData.Equals(police))
            {
                return View(SpringBootAppService.GetPoliceCarsForUser(police));
            }
            else if (RouteData.Equals(diplomat))
            {
                return View(SpringBootAppService.GetDiplomatCarsForUser(diplomat));
            }
            else
            {
                return View(SpringBootAppService.GetLicencePlateListForUser(inputPlate));
            }              
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