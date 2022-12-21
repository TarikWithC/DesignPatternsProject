using DesignPatterns.CreationalPatterns.FactoryMethod.Company.Employees;

namespace DesignPatterns.CreationalPatterns.FactoryMethod.Company.Abstractions
{
    public class DirectorFactory : IFactory
    {
        public Employee Create(string name)
        {
            var employee = new Director(name, 90000, "IT", "New Jersey");
            return employee;
        }
    }
}