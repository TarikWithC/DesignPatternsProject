using DesignPatterns.CreationalPatterns.FactoryMethodPatterns.Company.Employees;

namespace DesignPatterns.CreationalPatterns.FactoryMethodPatterns.Company.Abstractions
{
    public class DirectorFactory: IFactory
    {
        public Employee Create(string name)
        {
            var employee = new Director(name, 90000, "IT", "New Jersey");
            return employee;
        }
    }
}
