using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Contracts
{
    public class CarController : Controller
    {
        private readonly ICarService _carservice;

        public CarController(ICarService carService)
        {
            _carservice = carService;
        }
        public IActionResult Index()
        {
            return View(_carservice.Get());
        }
    }
}
