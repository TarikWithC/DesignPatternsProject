using DesignPatterns.CreationalPatterns.AbstractFactory.Abstractions;

namespace DesignPatterns.CreationalPatterns.AbstractFactory.Concretes.Air
{
    public class Jet : IFlyable
    {
        public Jet()
        {
            Console.WriteLine("Jet is created");
        }

        public void Fly()
        {
            Console.WriteLine("Jet is flying.");
        }
    }
}