using DesignPatterns.CreationalPatterns.Prototype.Game.Abstractions;
using DesignPatterns.CreationalPatterns.Prototype.Game.Enums;
using DesignPatterns.CreationalPatterns.Prototype.Game.Objects;

namespace DesignPatterns.CreationalPatterns.Prototype.Game.Factories
{
    internal class WeaponFactory : IWeaponFactory
    {
        private static readonly Weapon Prototype = new(EnumWeaponType.Unknown, 0, 0);
        private static readonly Weapon LowCaliberPrototype = new(EnumWeaponType.Pistol, 5.56, 14);
        private static readonly Weapon HighCaliberPrototype = new(EnumWeaponType.HeavyMachineGun, 7.62, 30);
        
        public Weapon CreatePistol()
        {
            var weapon = LowCaliberPrototype.Clone();
            return weapon;
        }

        public Weapon CreateSniperRifle()
        {
            var weapon = Prototype.Clone();
            weapon.AmmoCapacity = 12;
            weapon.Caliber = 7.62;
            weapon.WeaponType = EnumWeaponType.SniperRifle;
            return weapon;
        }

        public Weapon CreateMachineGun()
        {
            var weapon = Prototype.Clone();
            weapon.AmmoCapacity = 30;
            weapon.Caliber = 5.56;
            weapon.WeaponType = EnumWeaponType.SubMachineGun;
            return weapon;
        }

        public Weapon CreateHighCaliberMachineGun()
        {
            var weapon = CreateMachineGun();
            weapon.Caliber = 7.62;
            return weapon;
        }

        public Weapon CreateHeavyMachineGun()
        {
            var weapon = HighCaliberPrototype.Clone();
            return weapon;
        }
    }
}