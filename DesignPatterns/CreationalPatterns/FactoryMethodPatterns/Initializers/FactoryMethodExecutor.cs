using DesignPatterns.CreationalPatterns.FactoryMethodPatterns.Company.Abstractions;

namespace DesignPatterns.CreationalPatterns.FactoryMethodPatterns.Initializers
{
    public class FactoryMethodExecutor : IPatternExecutor
    {
        private const string PatternName = "Factory Method";
        private readonly IFactory _employeeFactory = new EmployeeFactory();
        private readonly IFactory _managerFactory = new ManagerFactory();
        private readonly IFactory _directorFactory = new DirectorFactory();

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