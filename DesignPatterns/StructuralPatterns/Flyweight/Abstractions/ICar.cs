using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralPatterns.Flyweight.Abstractions
{
    internal interface ICar
    {
        public string? Owner { get; set; }

        public string? PlateNumber { get; set; }

        public string Company { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }
    }
}
