using DesignPatterns.StructuralPatterns.Flyweight.Concretes;

namespace DesignPatterns.StructuralPatterns.Flyweight.Abstractions
{
    internal interface ICarGallery
    {
        List<Car> GetInventory();

        Car FindCarByPlate(string plateNumber);

        bool AddCarToInventory(Car car);

        bool RemoveCarFromInventory(Car car);

        bool UpdateOwnerByPlate(string plateNumber, string newOwner);

        bool UpdateOwnerByObject(Car car, string newOwnerName);

        void SellUnusedCar(Car car, string owner, string plateNumber);
    }
}