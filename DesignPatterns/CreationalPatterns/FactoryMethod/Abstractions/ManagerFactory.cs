using DesignPatterns.CreationalPatterns.FactoryMethod.Concretes;

namespace DesignPatterns.CreationalPatterns.FactoryMethod.Abstractions
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