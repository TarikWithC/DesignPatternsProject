using DesignPatterns.CreationalPatterns.FactoryMethodPatterns.Company.Abstractions;
using System;
using System.Collections.Generic;
using DesignPatterns.CreationalPatterns.AbstractFactoryPatterns.VehicleCompany.Abstractions;

namespace DesignPatterns.CreationalPatterns.AbstractFactoryPatterns.Initializers
{
    public class AbstractFactoryExecutor : IPatternExecutor
    {
        private const string PatternName = "Abstract Factory Method";
        private readonly IVehicleFactory _vehicleFactory = new VehicleFactory();
        public void Execute()
        {
            var car = _vehicleFactory.CreateCar();
            var truck = _vehicleFactory.CreateTruck();
            var jet = _vehicleFactory.CreateJet();
            var plane = _vehicleFactory.CreatePlane();

            car.Move();
            truck.Move();
            jet.Fly();
            plane.Fly();
        }

        public string GetPatternName()
        {
            return PatternName;
        }
    }
}
