using Homewors.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homewors.Service.Interfaces
{
    internal interface IProductService
    {
        internal interface IProductService
        {
            string SearchByName(string searchText);
            List<Product> GetProducts();
        }
    }
}
