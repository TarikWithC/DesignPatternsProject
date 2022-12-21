using DesignPatterns.CreationalPatterns.AbstractFactoryPatterns.VehicleCompany.Vehicles.Air;
using DesignPatterns.CreationalPatterns.AbstractFactoryPatterns.VehicleCompany.Vehicles.Land;

namespace DesignPatterns.CreationalPatterns.AbstractFactoryPatterns.VehicleCompany.Abstractions
{
    public interface IVehicleFactory
    {
        IDrivable CreateCar() => new Car();

        IDrivable CreateTruck() => new Truck();

        IFlyable CreateJet() => new Jet();

        IFlyable CreatePlane() => new Plane();
    }
}