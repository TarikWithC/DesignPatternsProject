using DesignPatterns.CreationalPatterns.AbstractFactory.VehicleCompany.Abstractions;

namespace DesignPatterns.CreationalPatterns.AbstractFactory.VehicleCompany.Vehicles.Air
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