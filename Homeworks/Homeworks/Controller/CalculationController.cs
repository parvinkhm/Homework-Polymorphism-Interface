using Homeworks.Service;
using Homeworks.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Homeworks.Controller
{
    internal class CalculationController
    {
        private readonly ICalculationService _calculationService;

        public CalculationController()
        {
            _calculationService = new CalculationService();
        }


        public void Calculate()
        {
            Console.WriteLine("Add first number");
            decimal n = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Add operation");
            string operation = Console.ReadLine();

            Console.WriteLine("Add second number");
            decimal m = Convert.ToDecimal(Console.ReadLine());  


            CalculationService calculationService = new CalculationService();
            calculationService.Calculate(n, operation, m);
        }

    }
}

