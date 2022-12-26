using Core.Helpers;
using Core.Interfaces;
using DesignPatterns.StructuralPatterns.Flyweight.Abstractions;
using DesignPatterns.StructuralPatterns.Flyweight.Concretes;

//credits: https://refactoring.guru/design-patterns/flyweight/csharp/example
namespace DesignPatterns.StructuralPatterns.Flyweight.Initializers
{
    internal class FlyweightTester : IPatternTester
    {
        private readonly ICarFactory _carFactory = new CarFactory();
        private readonly ICarGalleryFactory _carGalleryFactory = new CarGalleryFactory();
        private readonly Random _random = new();

        public void Test()
        {
            Console.WriteLine("What is your name?");
            var ownerName = ConsoleReader.ReadStringFromConsole();
            var carGallery = _carGalleryFactory.CreateIstanbulBranch(ownerName);

            Console.WriteLine("How many Mustangs do you want to add your gallery?");
            var mustangCount = ConsoleReader.ReadIntegerFromConsole();
            var mustang = _carFactory.CreateBlackMustang(); //-> Flyweight Object

            for (var i = 0; i < mustangCount; i++)
            {
                carGallery.AddCarToInventory(new Car(
                    owner: ownerName,
                    color: mustang.Color,
                    model: mustang.Model,
                    company: mustang.Company,
                    plateNumber: _random.Next(10000, 99999).ToString() + Convert.ToChar(_random.Next(65, 90))));
            }

            Console.WriteLine("How many RedBull RB-13 do you want to add to your gallery?");
            var redBullCount = ConsoleReader.ReadIntegerFromConsole();
            var redBull = _carFactory.CreateRedBullRb13(); //-> Flyweight Object
            for (var i = 0; i < redBullCount; i++)
            {
                carGallery.AddCarToInventory(new Car(
                    owner: ownerName,
                    color: redBull.Color,
                    model: redBull.Model,
                    company: redBull.Company,
                    plateNumber: _random.Next(10000, 99999).ToString() + Convert.ToChar(_random.Next(65, 90))));
            }

            Console.WriteLine("Cars in your gallery:");
            foreach (var item in carGallery.GetInventory())
            {
                item.PrintInfo();
            }
        }
    }
}