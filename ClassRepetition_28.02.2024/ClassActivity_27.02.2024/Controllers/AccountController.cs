
using ClassActivity_27._02._2024.Helpers.Constants;
using ClassActivity_27._02._2024.Services;
using System.Runtime.CompilerServices;

namespace ClassActivity_27._02._2024.Controllers
{
    internal class AccountController
    {
        private readonly AccountService _accountService;
        public AccountController()
        {
            _accountService = new AccountService();
        }

        public void Login()
        {
            Email: Console.WriteLine("Add your email:");
            string email = Console.ReadLine();

            if (!email.Contains("@"))
            {
                Console.WriteLine(ResponseMessages.IncorrectEmailFormat);
                goto Email;
            }

            Console.WriteLine("Add your password:");
            string password = Console.ReadLine();

            var response = _accountService.Login(email, password);

            if (response)
            {
                Console.WriteLine(ResponseMessages.SuccessfullLogin);
            }
            else
            {
                Console.WriteLine(ResponseMessages.ErrorMessage);
            }
        }
    }
}
