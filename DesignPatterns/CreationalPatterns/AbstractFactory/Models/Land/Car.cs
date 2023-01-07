using DesignPatterns.CreationalPatterns.AbstractFactory.Abstractions;

namespace DesignPatterns.CreationalPatterns.AbstractFactory.Concretes.Land
{
    public class Car : IDrivable
    {
        public Car()
        {
            Console.WriteLine("Car is created.");
        }

        public void Move()
        {
            Console.WriteLine("Car is moving.");
        }
    }
}