using DesignPatterns.CreationalPatterns.AbstractFactory.Concretes.Air;
using DesignPatterns.CreationalPatterns.AbstractFactory.Concretes.Land;

namespace DesignPatterns.CreationalPatterns.AbstractFactory.Abstractions
{
    public interface IVehicleFactory
    {
        IDrivable CreateCar() => new Car();

        IDrivable CreateTruck() => new Truck();

        IFlyable CreateJet() => new Jet();

        IFlyable CreatePlane() => new Plane();
    }
}