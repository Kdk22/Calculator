﻿using System;

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebServiceFinalLibrary;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebServiceAPI.Controllers
{
    public class CalculatorATIController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        [Route("api/[controller]/[action]")]
        [ApiController]
        public class CalculatorController : ControllerBase
        {
            [HttpGet]
            public double addition(double val1, double val2)
            {
                return Calculator.addition(val1, val2);
            }

            [HttpGet]
            public double subtraction(double val1, double val2)
            {
                return Calculator.subtraction(val1, val2);
            }

            [HttpGet]
            public double multipication(double val1, double val2)
            {
                return Calculator.multipication(val1, val2);
            }

            [HttpGet]
            public double division(double val1, double val2)
            {
                return Calculator.division(val1, val2);
            }
        }
    }
}

