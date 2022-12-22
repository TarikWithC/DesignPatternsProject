using DesignPatterns.CreationalPatterns.AbstractFactory.Abstractions;

namespace DesignPatterns.CreationalPatterns.AbstractFactory.Concretes.Land
{
    public class Truck : IDrivable
    {
        public Truck()
        {
            Console.WriteLine("Truck is created.");
        }

        public void Move()
        {
            Console.WriteLine("Truck is moving");
        }
    }
}