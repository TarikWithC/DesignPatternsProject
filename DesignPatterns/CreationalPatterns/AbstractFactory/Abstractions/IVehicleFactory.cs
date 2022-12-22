using DesignPatterns.CreationalPatterns.AbstractFactory.VehicleCompany.Vehicles.Air;
using DesignPatterns.CreationalPatterns.AbstractFactory.VehicleCompany.Vehicles.Land;

namespace DesignPatterns.CreationalPatterns.AbstractFactory.VehicleCompany.Abstractions
{
    public interface IVehicleFactory
    {
        IDrivable CreateCar() => new Car();

        IDrivable CreateTruck() => new Truck();

        IFlyable CreateJet() => new Jet();

        IFlyable CreatePlane() => new Plane();
    }
}