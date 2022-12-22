using DesignPatterns.CreationalPatterns.FactoryMethod.Concretes;

namespace DesignPatterns.CreationalPatterns.FactoryMethod.Abstractions
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