using DesignPatterns.CreationalPatterns.AbstractFactory.VehicleCompany.Abstractions;

namespace DesignPatterns.CreationalPatterns.AbstractFactory.VehicleCompany.Vehicles.Air
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