using DesignPatterns.CreationalPatterns.AbstractFactoryPatterns.VehicleCompany.Abstractions;

namespace DesignPatterns.CreationalPatterns.AbstractFactoryPatterns.VehicleCompany.Vehicles.Land
{
    public class Car : IDrivable
    {
        public Car()
        {
            Console.WriteLine("Car is created.");
        }

        public void Move()
        {
            Console.WriteLine("Car is moving.");
        }
    }
}