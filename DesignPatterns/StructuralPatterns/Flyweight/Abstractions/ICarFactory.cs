using DesignPatterns.StructuralPatterns.Flyweight.Concretes;

namespace DesignPatterns.StructuralPatterns.Flyweight.Abstractions
{
    internal interface ICarFactory
    {
        public Car CreateRedFordFocus();

        public Car CreateWhiteMustang();

        public Car CreateBlueMercedesAmg();

        public Car CreateBlackMustang();

        public Car CreateRedBullRb13();
    }
}