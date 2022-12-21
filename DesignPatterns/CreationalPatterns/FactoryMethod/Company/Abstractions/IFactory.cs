using DesignPatterns.CreationalPatterns.FactoryMethod.Company.Employees;

namespace DesignPatterns.CreationalPatterns.FactoryMethod.Company.Abstractions
{
    public interface IFactory
    {
        public Employee Create(string name);
    }
}