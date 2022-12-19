using DesignPatterns.CreationalPatterns.FactoryMethodPatterns.Company.Employees;

namespace DesignPatterns.CreationalPatterns.FactoryMethodPatterns.Company.Abstractions
{
    public interface IFactory
    {
        public Employee Create(string name);
    }
}