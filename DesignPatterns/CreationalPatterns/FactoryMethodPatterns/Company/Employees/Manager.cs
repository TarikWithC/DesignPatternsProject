using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.FactoryMethodPatterns.Company.Employees
{
    public class Manager: Employee
    {
        private string ResponsibleDepartment { get; }

        public Manager(string name, int salary, string responsibleDepartment) : base(name, salary)
        {
            ResponsibleDepartment = responsibleDepartment;
        }

        public override void Work()
        {
            Console.WriteLine("Manager is working.");
        }

        public string GetResponsibleDepartment()
        {
            return ResponsibleDepartment;
        }

        public void ManageEmployees()
        {
            Console.WriteLine("Managing employees.");
        }

    }
}
