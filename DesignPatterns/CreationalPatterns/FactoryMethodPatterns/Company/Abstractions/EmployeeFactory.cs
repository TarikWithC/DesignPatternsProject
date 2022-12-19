using DesignPatterns.CreationalPatterns.FactoryMethodPatterns.Company.Employees;

namespace DesignPatterns.CreationalPatterns.FactoryMethodPatterns.Company.Abstractions
{
    public class EmployeeFactory: IFactory
    {
        public Employee Create(string name)
        {
            var employee = new Employee(name, 50000);
            return employee;
        }
    }
}
