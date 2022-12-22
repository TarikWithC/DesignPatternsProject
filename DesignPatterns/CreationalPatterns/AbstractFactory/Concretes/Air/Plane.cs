using DesignPatterns.CreationalPatterns.AbstractFactory.Abstractions;

namespace DesignPatterns.CreationalPatterns.AbstractFactory.Concretes.Air
{
    public class Plane : IFlyable
    {
        public Plane()
        {
            Console.WriteLine("Plane is created");
        }

        public void Fly()
        {
            Console.WriteLine("Plane is flying.");
        }
    }
}