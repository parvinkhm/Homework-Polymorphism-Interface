using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homeworks.Service.Interface;

namespace Homeworks.Service
{
    internal class CalculationService : ICalculationService
    {
        public void Calculate(decimal n, string operation, decimal m)
        {
            decimal result;

            switch (operation)
            {
                case "+":
                    result = n + m;
                    Console.WriteLine(result);
                    break;
                case "-":
                    result = n - m;
                    Console.WriteLine(result);
                    break;
                case "*":
                    result = n * m;
                    Console.WriteLine(result);
                    break;
                case "/":
                    result = n / m;
                    Console.WriteLine(result);
                    break;
            }
        }
    }
}
