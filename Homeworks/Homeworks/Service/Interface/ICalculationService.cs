﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworks.Service.Interface
{
    internal interface ICalculationService
    {
        public void Calculate(decimal n, string operation, decimal m);
    }
}
