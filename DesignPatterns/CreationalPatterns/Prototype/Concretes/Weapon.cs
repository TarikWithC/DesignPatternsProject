using DesignPatterns.CreationalPatterns.Prototype.Game.Enums;

namespace DesignPatterns.CreationalPatterns.Prototype.Game.Objects
{
    public class Weapon
    {
        public EnumWeaponType WeaponType { get; set; }
        public double Caliber { get; set; }
        public int AmmoCapacity { get; set; }

        public Weapon(EnumWeaponType weaponType, double caliber, int ammoCapacity)
        {
            WeaponType = weaponType;
            Caliber = caliber;
            AmmoCapacity = ammoCapacity;
            Console.WriteLine("Weapon constructor call.");
        }

        public void PrintInfo()
        {
            Console.WriteLine($"\nCURRENT CREATED WEAPON STATS:\n" +
                              $"AmmoCapacity: {this.AmmoCapacity}\n" +
                              $"Caliber: {this.Caliber}\n" +
                              $"WeaponType: {this.WeaponType}\n");
        }

        public Weapon Clone()
        {
            return (MemberwiseClone() as Weapon)!;
        }
    }
}