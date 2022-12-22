using DesignPatterns.CreationalPatterns.FactoryMethod.Company.Employees;

namespace DesignPatterns.CreationalPatterns.FactoryMethod.Company.Abstractions
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