using Homewors.Models;
using Homewors.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homewors
{
        internal class AccountService : IAccountService
        {
            public List<User> GetUsers()
            {
                List<User> list = new()
            {
                new User {Id=1,Email="sheref@gmail.com",Password="sheref123"},
                new User {Id=1,Email="samir@gmail.com",Password="samir123"},
                new User {Id=1,Email="pervin@gmail.com",Password="pervin123"},
            };
                return list;
            }

            public bool Login(string username, string password)
            {
                var users = GetUsers();
                foreach (var item in users)
                {
                    if (username == item.Email && password == item.Password)
                    {
                        return true;

                    }
                }
                return false;
            }

        public void ShowMenu()
        {
            throw new NotImplementedException();
        }

        string IAccountService.Login(string username, string password)
        {
            throw new NotImplementedException();
        }
    }
    
}
