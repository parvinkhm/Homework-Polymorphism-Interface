using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repeat.Services.Interfaces
{
    internal interface ICustomMathService
    {
        void Sum(int a, int b);
        int GetNumbersofSum(int[] nums);
        double PowOfNum(int num, int pow);
        //int SquareOfNum(int num);
    }
}
