using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using IPCalculator.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace IPCalculator.Controllers
{
    public class CalculatorController : Controller
    {
        //
        // GET: /<controller>/

        [HttpGet]
        public IActionResult Index()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(IPAddressModel iPAddressModel)
        {
            
            return View(iPAddressModel.getHexIP());
        }

    }
}

