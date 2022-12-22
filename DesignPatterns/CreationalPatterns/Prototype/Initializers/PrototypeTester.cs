using Core.Constants;
using Core.Helpers;
using Core.Interfaces;
using DesignPatterns.CreationalPatterns.Prototype.Abstractions;
using DesignPatterns.CreationalPatterns.Prototype.Constants;
using DesignPatterns.CreationalPatterns.Prototype.Enums;
using DesignPatterns.CreationalPatterns.Prototype.Factories;

namespace DesignPatterns.CreationalPatterns.Prototype.Initializers
{
    internal class PrototypeTester : IPatternTester
    {
        private readonly ISoldierFactory _soldierFactory = new SoldierFactory();
        private readonly IVehicleFactory _vehicleFactory = new VehicleFactory();
        private readonly IWeaponFactory _weaponFactory = new WeaponFactory();

        public void Test()
        {
            Console.WriteLine("------------------");

            Console.WriteLine(PrototypeConsoleMessages.MainQuestion);
            var objectChoice = ConsoleReader.ReadIntegerFromConsole();

            switch (objectChoice)
            {
                case 0: return;
                case (int)EnumObjectType.Soldier: SoldierTest(); break;
                case (int)EnumObjectType.Vehicle: VehicleTest(); break;
                case (int)EnumObjectType.Weapon: WeaponTest(); break;
                default: Console.WriteLine(ConsoleMessages.CommandNotFound); break;
            }

            Console.WriteLine("------------------");
        }

        private void SoldierTest()
        {
            Console.WriteLine(PrototypeConsoleMessages.SoldierQuestion);
            var soldierChoice = ConsoleReader.ReadIntegerFromConsole();
            Console.WriteLine(PrototypeConsoleMessages.SoldierNameQuestion);
            var soldierName = ConsoleReader.ReadStringFromConsole();
            switch (soldierChoice)
            {
                case 0: return;
                case 1: _soldierFactory.CreateBlueTeamMedic(soldierName).PrintInfo(); break;
                case 2: _soldierFactory.CreateBlueTeamSniper(soldierName).PrintInfo(); break;
                case 3: _soldierFactory.CreateRedTeamMedic(soldierName).PrintInfo(); break;
                case 4: _soldierFactory.CreateRedTeamSniper(soldierName).PrintInfo(); break;
                default: Console.WriteLine(PrototypeConsoleMessages.NoSuchTypeError); break;
            }
        }

        private void VehicleTest()
        {
            Console.WriteLine(PrototypeConsoleMessages.VehicleQuestion);
            var vehicleChoice = ConsoleReader.ReadIntegerFromConsole();
            Console.WriteLine(PrototypeConsoleMessages.VehicleIdQuestion);
            var vehicleId = ConsoleReader.ReadIntegerFromConsole();
            switch (vehicleChoice)
            {
                case 0: return;
                case 1: _vehicleFactory.CreateRedCar(vehicleId).PrintInfo(); break;
                case 2: _vehicleFactory.CreateRedTruck(vehicleId).PrintInfo(); break;
                case 3: _vehicleFactory.CreateBlueTank(vehicleId).PrintInfo(); break;
                default: Console.WriteLine(PrototypeConsoleMessages.NoSuchTypeError); break;
            }
        }

        private void WeaponTest()
        {
            Console.WriteLine(PrototypeConsoleMessages.WeaponQuestion);
            var weaponChoice = ConsoleReader.ReadIntegerFromConsole();
            switch (weaponChoice)
            {
                case 0: return;
                case 1: _weaponFactory.CreatePistol().PrintInfo(); break;
                case 2: _weaponFactory.CreateMachineGun().PrintInfo(); break;
                case 3: _weaponFactory.CreateHeavyMachineGun().PrintInfo(); break;
                case 4: _weaponFactory.CreateHighCaliberMachineGun().PrintInfo(); break;
                case 5: _weaponFactory.CreateSniperRifle().PrintInfo(); break;
                default: Console.WriteLine(PrototypeConsoleMessages.NoSuchTypeError); break;
            }
        }
    }
}