using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OdeToFood.Controllers
{
    [Route("[controller]")]
    public class AboutController : Controller
    {
        public IActionResult Phone()
        {
            return Content( "+55(21) 9 9999-9999");
        }

        [Route("address")]
        public IActionResult Address()
        {
            return Content("BRL");
        }
    }
}
