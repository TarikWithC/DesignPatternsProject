using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
