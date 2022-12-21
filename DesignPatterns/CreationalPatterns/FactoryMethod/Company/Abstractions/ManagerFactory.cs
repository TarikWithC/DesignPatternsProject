using DesignPatterns.CreationalPatterns.FactoryMethodPatterns.Company.Employees;

namespace DesignPatterns.CreationalPatterns.FactoryMethodPatterns.Company.Abstractions
{
    public class ManagerFactory : IFactory
    {
        public Employee Create(string name)
        {
            var employee = new Manager(name, 70000, "IT");
            return employee;
        }
    }
}