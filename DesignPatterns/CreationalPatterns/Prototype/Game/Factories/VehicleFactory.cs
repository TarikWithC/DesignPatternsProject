using DesignPatterns.CreationalPatterns.Prototype.Game.Abstractions;
using DesignPatterns.CreationalPatterns.Prototype.Game.Enums;
using DesignPatterns.CreationalPatterns.Prototype.Game.Objects;

namespace DesignPatterns.CreationalPatterns.Prototype.Game.Factories
{
    internal class VehicleFactory : IVehicleFactory
    {
        private static readonly Vehicle BlueTeamPrototype = new(1, EnumTeam.Blue, EnumVehicleType.Unknown);
        private static readonly Vehicle RedTeamPrototype = new(1, EnumTeam.Red, EnumVehicleType.Unknown);

        public Vehicle CreateRedCar(int id)
        {
            var vehicle = RedTeamPrototype.Clone();
            vehicle.Id = id;
            vehicle.VehicleType = EnumVehicleType.Car;
            return vehicle;
        }

        public Vehicle CreateRedTruck(int id)
        {
            var vehicle = RedTeamPrototype.Clone();
            vehicle.Id = id;
            vehicle.VehicleType = EnumVehicleType.Truck;
            return vehicle;
        }

        public Vehicle CreateBlueTank(int id)
        {
            var vehicle = BlueTeamPrototype.Clone();
            vehicle.Id = id;
            vehicle.VehicleType = EnumVehicleType.Tank;
            return vehicle;
        }
    }
}