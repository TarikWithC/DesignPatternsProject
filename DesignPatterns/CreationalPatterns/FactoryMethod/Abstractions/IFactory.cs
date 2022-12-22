using DesignPatterns.CreationalPatterns.FactoryMethod.Concretes;

namespace DesignPatterns.CreationalPatterns.FactoryMethod.Abstractions
{
    public interface IFactory
    {
        public Employee Create(string name);
    }
}