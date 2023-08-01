using Homewors.Service.Helpers;
using Homewors.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homewors.Controllers
{
    internal class AccountController
    {
        private readonly IAccountService _accountService;
        private readonly IProductService _productService;
        public AccountController()
        {
            _accountService = new AccountService();
            _productService = new ProductService();
        }

        public void Login()
        {
            Console.WriteLine("Add email :");
            string email = Console.ReadLine();

            Console.WriteLine("Add password :");
            string password = Console.ReadLine();

            string result = _accountService.Login(email, password);

            Console.WriteLine(result);
        }
    }
}

