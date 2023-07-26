using Repeat.Services;
using Repeat.Services.Interfaces;

namespace Repeat.Controllers
{
    internal class AccountController
    {
        private readonly IAccountService _accountService;

        public AccountController()
        {
            _accountService = new AccountService();
        }

        public void Login()
        {
            Console.WriteLine("Add email: ");
            string email = Console.ReadLine();

            Console.WriteLine("Add password: ");
            string password = Console.ReadLine();

            string result = _accountService.Login(email, password);

            Console.WriteLine(result);
        }
    }
}
