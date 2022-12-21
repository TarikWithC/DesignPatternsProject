using DesignPatterns.CreationalPatterns.Prototype.Game.Objects;

namespace DesignPatterns.CreationalPatterns.Prototype.Game.Abstractions
{
    internal interface IWeaponFactory
    {
        public Weapon CreatePistol();

        public Weapon CreateSniperRifle();

        public Weapon CreateMachineGun();

        public Weapon CreateHighCaliberMachineGun();

        public Weapon CreateHeavyMachineGun();
    }
}