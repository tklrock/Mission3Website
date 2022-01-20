using Microsoft.AspNetCore.Mvc;
using Mission3Website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission3Website.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //Method to view the grade calculator page
        [HttpGet]
        public IActionResult GradeCalculator()
        {
            return View();
        }

        //Method used when using post with the calculator model
        [HttpPost]
        public IActionResult GradeCalculator(CalculatorModel model)
        {
            return View();
        }
    }
}
