using Repeat.Models;
using Repeat.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repeat.Services
{
    internal class EmployeeService : IEmployeeService

    {
        public List<Employee> GetAll()
        {
            List<Employee> list = new List<Employee>();

            list.Add(new Employee { Id = 1, FullName = "Ismayil Efendizade",Age = 29, Salary = 2000});   
            list.Add(new Employee { Id = 2, FullName = "Samir Qehremanov",Age = 25, Salary = 2500});   
            list.Add(new Employee { Id = 3, FullName = "Fidan Besirova",Age = 22, Salary = 3000});   
            list.Add(new Employee { Id = 4, FullName = "Kubra Memmedova",Age = 25, Salary = 2400});
            list.Add(new Employee { Id = 5, FullName = "Pervin Mirzeyev", Age = 30, Salary = 4500 });

            return list;
        }

        public List<Employee> FilterBySalary(decimal firstSalary, decimal secondsalary, List<Employee> employees)
        {
           return employees.FindAll(m=>m.Salary > firstSalary && m.Salary < secondsalary);
        }
    }
}
