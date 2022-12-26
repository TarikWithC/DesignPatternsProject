﻿using DesignPatterns.StructuralPatterns.Flyweight.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralPatterns.Flyweight.Concretes
{
    internal class Car : ICar
    {
        //Instinct
        public string? Owner { get; set; }
        public string? PlateNumber { get; set; }

        //Distinct
        public string Color { get; set; }
        public string Company { get; set; }
        public string Model { get; set; }

        public Car(string? owner, string? plateNumber, string color, string company, string model)
        {
            Owner = owner;
            PlateNumber = plateNumber;
            Color = color;
            Company = company;
            Model = model;
        }

        public Car(string color, string company, string model)
        {
            Color = color;
            Company = company;
            Model = model;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Owner: {Owner}, Plate Number: {PlateNumber}, Color: {Color}, Company: {Company}, Model: {Model}");
        }
    }
}