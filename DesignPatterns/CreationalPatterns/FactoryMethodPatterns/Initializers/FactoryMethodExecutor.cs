using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.CreationalPatterns.FactoryMethodPatterns.Company.Abstractions;

namespace DesignPatterns.CreationalPatterns.FactoryMethodPatterns.Initializers
{
    public class FactoryMethodExecutor: IPatternExecutor
    {
        private const string PatternName  = "Factory Method";
        private readonly EmployeeFactory _employeeFactory = new ();
        private readonly ManagerFactory _managerFactory = new ();
        private readonly DirectorFactory _directorFactory = new ();
        public void Execute()
        {
            var employee = _employeeFactory.Create("Test Employee");
            var manager = _managerFactory.Create("Test Manager");
            var director = _directorFactory.Create("Test Director");

            employee.Work();
            manager.Work();
            director.Work();
            //Console.WriteLine(director.GetType().Name);
        }

        public string GetPatternName()
        {
            return PatternName;
        }
    }
}
