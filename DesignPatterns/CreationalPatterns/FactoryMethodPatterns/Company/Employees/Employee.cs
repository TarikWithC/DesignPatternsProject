using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.CreationalPatterns.FactoryMethodPatterns.Company.Abstractions;

namespace DesignPatterns.CreationalPatterns.FactoryMethodPatterns.Company.Employees
{
    public class Employee
    {
        private string Name { get;  }
        private int Salary { get;  }

        public Employee(string name, int salary)
        {
            Name = name;
            Salary = salary;
        }

        public virtual void Work()
        {
            Console.WriteLine("Employee is working.");
        }

        public string GetName()
        {
            return Name;
        }

        public int GetSalary()
        {
            return Salary;
        }
    }
}
