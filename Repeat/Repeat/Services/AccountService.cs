using Repeat.Helpers.ResponseMessages;
using Repeat.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repeat.Services
{
    internal class AccountService : IAccountService
    {
        public string Login(string email, string password)
        {
            if (email == "x@gmail.com" && password == "x123")
            {
                return AccountMessages.LoginSuccess;
            }
            return AccountMessages.LoginFailed;
        }
    }
}
