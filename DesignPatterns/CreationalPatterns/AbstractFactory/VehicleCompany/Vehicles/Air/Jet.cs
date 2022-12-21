using DesignPatterns.CreationalPatterns.AbstractFactoryPatterns.VehicleCompany.Abstractions;

namespace DesignPatterns.CreationalPatterns.AbstractFactoryPatterns.VehicleCompany.Vehicles.Air
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