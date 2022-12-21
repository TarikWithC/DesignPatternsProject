using DesignPatterns.CreationalPatterns.FactoryMethod.Company.Employees;

namespace DesignPatterns.CreationalPatterns.FactoryMethod.Company.Abstractions
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