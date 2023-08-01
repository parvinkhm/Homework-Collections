using Homewors.Models;
using Homewors.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homewors
{
    internal class ProductService : IProductService
    {
            public List<Product> GetProducts()
            {
                List<Product> list = new List<Product>();
                {
                    list.Add(new Product { Id = 1, Name = "Sheref", Price = 26, Count = 10 });
                    list.Add(new Product { Id = 2, Name = " Samir", Price = 25, Count =15 });
                    list.Add(new Product { Id = 3, Name = "Cahangir", Price = 22, Count = 25 });
                    list.Add(new Product { Id = 4, Name = "Ismayil", Price = 29, Count =30 });
                };
                return list;
            }

            public string SearchByName(string searchText)
            {
                var products = GetProducts();
                foreach (var item in products)
                {
                    if (item.Name.Trim().ToLower().Contains(searchText.ToLower().Trim()))
                    {
                        Console.WriteLine($"{item.Id},{item.Name} ,{item.Price} {item.Count}");
                    }
                }
                return null;
            }
        
    }
}
