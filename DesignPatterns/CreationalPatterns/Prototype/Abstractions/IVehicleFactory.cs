using DesignPatterns.CreationalPatterns.Prototype.Concretes;

namespace DesignPatterns.CreationalPatterns.Prototype.Abstractions
{
    internal interface IVehicleFactory
    {
        public Vehicle CreateRedCar(int id);

        public Vehicle CreateRedTruck(int id);

        public Vehicle CreateBlueTank(int id);
    }
}