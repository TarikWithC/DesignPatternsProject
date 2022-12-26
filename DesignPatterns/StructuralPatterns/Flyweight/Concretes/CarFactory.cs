using DesignPatterns.StructuralPatterns.Flyweight.Abstractions;

namespace DesignPatterns.StructuralPatterns.Flyweight.Concretes
{
    internal class CarFactory : ICarFactory
    {
        public Car CreateBlackMustang()
        {
            var car = new Car(color: "Black", "Ford", "Mustang");
            return car;
        }

        public Car CreateBlueMercedesAmg()
        {
            var car = new Car(color: "Blue", "Mercedes", "Amg");
            return car;
        }

        public Car CreateRedBullRb13()
        {
            var car = new Car(color: "Red", "RedBull", "Rb13");
            return car;
        }

        public Car CreateRedFordFocus()
        {
            var car = new Car(color: "Red", "Ford", "Mustang");
            return car;
        }

        public Car CreateWhiteMustang()
        {
            var car = new Car(color: "White", "Ford", "Mustang");
            return car;
        }
    }
}
