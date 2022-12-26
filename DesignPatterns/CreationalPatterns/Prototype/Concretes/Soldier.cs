using DesignPatterns.CreationalPatterns.Prototype.Enums;

namespace DesignPatterns.CreationalPatterns.Prototype.Concretes
{
    public class Soldier
    {
        public int Level { get; set; }
        public string? Name { get; set; }
        public EnumTeam? Team { get; set; }
        public EnumSoldierType Type { get; set; }
        public Weapon? Weapon { get; set; }

        public Soldier(int level, string? name, EnumTeam team, EnumSoldierType type, Weapon? weapon)
        {
            Level = level;
            Name = name;
            Team = team;
            Type = type;
            Weapon = weapon;
            Console.WriteLine("Soldier constructor call.");
        }

        public void PrintInfo()
        {
            Console.WriteLine($"\nCURRENT CREATED SOLDIER STATS:\n" +
                              $"Level: {this.Level}\n" +
                              $"Name: {this.Name}\n" +
                              $"Team: {this.Team}\n" +
                              $"Type: {this.Type}\n" +
                              $"Weapon Type: {this.Weapon?.WeaponType}\n" +
                              $"Weapon Ammo Cap: {this.Weapon?.AmmoCapacity}");
        }

        public Soldier Clone()
        {
            return (MemberwiseClone() as Soldier)!;
        }
    }
}