using DesignPatterns.CreationalPatterns.AbstractFactoryPatterns.VehicleCompany.Abstractions;

namespace DesignPatterns.CreationalPatterns.AbstractFactoryPatterns.VehicleCompany.Vehicles.Land
{
    public class Truck : IDrivable
    {
        public void Move()
        {
            Console.WriteLine("Truck is moving");
        }
    }
}