using DesignPatterns.CreationalPatterns.Prototype.Concretes;

namespace DesignPatterns.CreationalPatterns.Prototype.Abstractions
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