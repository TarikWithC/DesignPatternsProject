using Core.Interfaces;
using DesignPatterns.CreationalPatterns.FactoryMethodPatterns.Company.Abstractions;

namespace DesignPatterns.CreationalPatterns.FactoryMethodPatterns.Initializers
{
    internal sealed class FactoryMethodTester : IPatternTester
    {
        private readonly IFactory _employeeFactory = new EmployeeFactory();
        private readonly IFactory _managerFactory = new ManagerFactory();
        private readonly IFactory _directorFactory = new DirectorFactory();

        public void Test()
        {
            Console.WriteLine("------------------");
            var employee = _employeeFactory.Create("Test Employee");
            var manager = _managerFactory.Create("Test Manager");
            var director = _directorFactory.Create("Test Director");
            employee.Work();
            manager.Work();
            director.Work();
            //Console.WriteLine(director.GetType().Name);
            Console.WriteLine("------------------");
        }
    }
}