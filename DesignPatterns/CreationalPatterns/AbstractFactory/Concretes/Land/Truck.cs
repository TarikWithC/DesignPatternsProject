using DesignPatterns.CreationalPatterns.AbstractFactory.VehicleCompany.Abstractions;

namespace DesignPatterns.CreationalPatterns.AbstractFactory.VehicleCompany.Vehicles.Land
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