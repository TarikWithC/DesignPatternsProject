using DesignPatterns.CreationalPatterns.AbstractFactoryPatterns.VehicleCompany.Abstractions;

namespace DesignPatterns.CreationalPatterns.AbstractFactoryPatterns.VehicleCompany.Vehicles.Land
{
    public class Car : IDrivable
    {
        public void Move()
        {
            Console.WriteLine("Car is moving.");
        }
    }
}