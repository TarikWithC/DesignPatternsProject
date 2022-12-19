using DesignPatterns.CreationalPatterns.AbstractFactoryPatterns.VehicleCompany.Abstractions;

namespace DesignPatterns.CreationalPatterns.AbstractFactoryPatterns.VehicleCompany.Vehicles.Air
{
    public class Jet : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("Jet is flying.");
        }
    }
}