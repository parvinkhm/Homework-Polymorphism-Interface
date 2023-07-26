using Repeat.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repeat.Services
{
    internal class CustomMathService : ICustomMathService
    {
        public int GetNumbersofSum(int[] nums)
        {
            int sum = 0;
            foreach (var item in nums)
            {
                sum += item;
            }
            return sum; 
        }
        //public int SquareOfNum(int num)
        public double PowOfNum(int num, int pow)
        {
            var result =Math.Pow(num, pow);
            return result;
        }

        public void Sum(int a, int b)
        {
            int sum = a + b;
            Console.WriteLine(sum);
        }

    }
}
