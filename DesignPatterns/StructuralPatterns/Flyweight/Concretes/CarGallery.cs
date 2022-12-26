using DesignPatterns.CreationalPatterns.AbstractFactory.Concretes.Land;
using DesignPatterns.StructuralPatterns.Flyweight.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralPatterns.Flyweight.Concretes
{
    internal class CarGallery : ICarGallery
    {
        public string City { get; set; }
        public string District { get; set; }
        public string Owner { get; set; }
        public int CarCapacity { get; set; }
        public List<Car> Cars { get; set; } = new();

        public CarGallery(string city, string district, string owner, int carCapacity)
        {
            City = city;
            District = district;
            Owner = owner;
            CarCapacity = carCapacity;
        }

        public List<Car> GetInventory()
        {
            return Cars;
        }

        public Car FindCarByPlate(string plateNumber)
        {
            try
            {
                var car = Cars.First(x => x.PlateNumber == plateNumber);
                return car;
            }
            catch (Exception)
            {
                throw new Exception("Error message");
            }
        }

        public bool AddCarToInventory(Car car)
        {
            if (Cars.Count < CarCapacity)
            {
                Cars.Add(car);
                return true;
            }
            return false;
        }

        public bool RemoveCarFromInventory(Car car)
        {
            var isSuccess = Cars.Remove(car);
            return isSuccess;
        }

        public bool UpdateOwnerByPlate(string plateNumber, string newOwner)
        {
            var carToUpdate = Cars.FirstOrDefault(x => x.PlateNumber == plateNumber);
            if (carToUpdate != null)
            {
                carToUpdate.Owner = newOwner;
                return true;
            }
            return false;
        }

        public bool UpdateOwnerByObject(Car car, string newOwnerName)
        {
            var carToUpdate = Cars.FirstOrDefault(x => x.PlateNumber == car.PlateNumber);
            if (carToUpdate != null)
            {
                carToUpdate.Owner = newOwnerName;
                return true;
            }
            return false;
        }

        public void SellUnusedCar(Car car, string owner, string plateNumber)
        {
            car.Owner = owner;
            car.PlateNumber = plateNumber;
        }
    }
}
