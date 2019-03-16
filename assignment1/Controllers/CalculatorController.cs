using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using assignment1.Models.Calc;
using Microsoft.AspNetCore.Authorization;

namespace assignment1.Controllers
{
    [Authorize]
    public class CalculatorController : Controller
    {
        public IActionResult Calculator()
        {
            return View();
        }

        public ActionResult getNumbers()
        {
            Calculator calc = new Calculator
            {
                PrincipalRate = 0,
                InterestRate = 0,
                TimePerYear = 0,
                Years = 0,
                Total = 0
            };
            return View(calc);
        }


        [HttpPost]
        public ActionResult setNumber(Calculator calc)
        {
            if (calc == null)
            {
                return NotFound();
            }


            double body = 1 + ((calc.InterestRate/100) / calc.TimePerYear);
            double exponent = calc.TimePerYear * calc.Years;
            calc.Total = calc.InterestRate * Math.Pow(body, exponent);

            TempData["result"] = calc.Total;

            return RedirectToAction(nameof(Calculator));

        }


    }
}
