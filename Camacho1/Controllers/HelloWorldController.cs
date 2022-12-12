using Microsoft.AspNetCore.Mvc;

namespace Camacho1.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string AnotherAction()
        {
            return "Another action was called!";
        }
    }
}
