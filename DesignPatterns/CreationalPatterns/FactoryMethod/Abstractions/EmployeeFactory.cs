using DesignPatterns.CreationalPatterns.FactoryMethod.Concretes;

namespace DesignPatterns.CreationalPatterns.FactoryMethod.Abstractions
{
    public class EmployeeFactory : IFactory
    {
        public Employee Create(string name)
        {
            var employee = new Employee(name, 50000);
            return employee;
        }
    }
}