using Homewors.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homewors.Service.Interfaces
{
    internal interface IAccountService
    {
            string Login(string username, string password);
            List<User> GetUsers();
            void ShowMenu();
        
    }
}
