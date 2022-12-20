using DesignPatterns.CreationalPatterns.AbstractFactoryPatterns.VehicleCompany.Abstractions;

namespace DesignPatterns.CreationalPatterns.AbstractFactoryPatterns.VehicleCompany.Vehicles.Air
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