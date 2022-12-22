using DesignPatterns.CreationalPatterns.Prototype.Game.Objects;

namespace DesignPatterns.CreationalPatterns.Prototype.Game.Abstractions
{
    internal interface IVehicleFactory
    {
        public Vehicle CreateRedCar(int id);

        public Vehicle CreateRedTruck(int id);

        public Vehicle CreateBlueTank(int id);
    }
}