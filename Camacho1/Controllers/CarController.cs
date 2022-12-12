using System.Security.Cryptography.X509Certificates;
using Camacho1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;
using Microsoft.AspNetCore.DataProtection.KeyManagement.Internal;

namespace Camacho1.Controllers
{
    public class CarController : Controller
    {
        private static List<CarViewModel> cars = new List<CarViewModel>();
        public IActionResult Index()
        {
            return View(cars);
        }

        public IActionResult Create()
        {
            var car = new CarViewModel();
            return View(car);
        }

        public IActionResult CreateCar(CarViewModel car)
        {
            cars.Add(car);
            return RedirectToAction(nameof(Index));
        }
    }
}
