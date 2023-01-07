using DesignPatterns.CreationalPatterns.Prototype.Enums;

namespace DesignPatterns.CreationalPatterns.Prototype.Concretes
{
    public class Vehicle
    {
        public int? Id { get; set; }
        public EnumTeam Team { get; set; }
        public EnumVehicleType VehicleType { get; set; }

        public Vehicle(int id, EnumTeam team, EnumVehicleType vehicleType)
        {
            Id = id;
            Team = team;
            VehicleType = vehicleType;
            Console.WriteLine("Vehicle constructor called.");
        }

        public void PrintInfo()
        {
            Console.WriteLine($"\nCURRENT CREATED VEHICLE STATS:\n" +
                              $"Id: {this.Id}\n" +
                              $"Team: {this.Team}\n" +
                              $"VehicleType: {this.VehicleType}\n");
        }

        public Vehicle Clone()
        {
            return (MemberwiseClone() as Vehicle)!;
        }
    }
}