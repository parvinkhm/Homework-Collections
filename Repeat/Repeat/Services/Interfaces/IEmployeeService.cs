using Repeat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repeat.Services.Interfaces
{
    internal interface IEmployeeService
    {
        List<Employee> GetAll();
        List<Employee> FilterBySalary(decimal firstSalary, decimal secondsalary, List<Employee> employees);
    }
}
