﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repeat.Services.Interfaces
{
    internal interface IAccountService
    {
        string Login(string email, string password);
    }
}
