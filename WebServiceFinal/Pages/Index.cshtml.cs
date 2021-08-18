using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using WebServiceFinalLibrary;

namespace WebServiceFinal.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
        public void OnPost(double value1, double value2, string operation)
        {
            switch (operation)
            {
                case "addition":
                    Output = Calculator.addition(val1, val2);
                    ResultValue = true;
                    break;
                case "subtraction":
                    Output = Calculator.subtraction(val1, val2);
                    ResultValue = true;
                    break;
                case "multipication":
                    Output = Calculator.multipication(val1, val2);
                    ResultValue = true;
                    break;
                case "division":
                    Output = Calculator.division(val1, val2);
                    ResultValue = true;
                    break;
                default:
                    break;
            }
        }
        public double Output { get; set; }
        public Boolean ResultValue { get; protected set; } = false;
    }
}
