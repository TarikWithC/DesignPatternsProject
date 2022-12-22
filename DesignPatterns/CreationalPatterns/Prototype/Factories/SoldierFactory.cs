using DesignPatterns.CreationalPatterns.Prototype.Abstractions;
using DesignPatterns.CreationalPatterns.Prototype.Concretes;
using DesignPatterns.CreationalPatterns.Prototype.Enums;

namespace DesignPatterns.CreationalPatterns.Prototype.Factories
{
    internal class SoldierFactory : ISoldierFactory
    {
        private static readonly IWeaponFactory WeaponFactory = new WeaponFactory();
        private static readonly Soldier RedTeamPrototype = new(10, null, EnumTeam.Red, EnumSoldierType.PistolUser, null);
        private static readonly Soldier BlueTeamPrototype = new(10, null, EnumTeam.Blue, EnumSoldierType.PistolUser, null);
        //private static readonly Soldier Soldier = new (1, null, EnumTeam.Unknown, EnumSoldierType.PistolUser, null);
        public Soldier CreateBlueTeamMedic(string name)
        {
            var soldier = BlueTeamPrototype.Clone();
            soldier.Name = name;
            soldier.Weapon = WeaponFactory.CreateMachineGun();
            soldier.Type = EnumSoldierType.Medic;
            return soldier;
        }

        public Soldier CreateBlueTeamSniper(string name)
        {
            var soldier = BlueTeamPrototype.Clone();
            soldier.Name = name;
            soldier.Weapon = WeaponFactory.CreateSniperRifle();
            soldier.Type = EnumSoldierType.Sniper;
            return soldier;
        }

        public Soldier CreateRedTeamMedic(string name)
        {
            var soldier = RedTeamPrototype.Clone();
            soldier.Name = name;
            soldier.Weapon = WeaponFactory.CreateMachineGun();
            soldier.Type = EnumSoldierType.Medic;
            return soldier;
        }

        public Soldier CreateRedTeamSniper(string name)
        {
            var soldier = RedTeamPrototype.Clone();
            soldier.Name = name;
            soldier.Weapon = WeaponFactory.CreateSniperRifle();
            soldier.Type = EnumSoldierType.Sniper;
            return soldier;
        }
    }
}