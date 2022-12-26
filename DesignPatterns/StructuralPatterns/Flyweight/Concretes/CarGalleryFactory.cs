using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.StructuralPatterns.Flyweight.Abstractions;

namespace DesignPatterns.StructuralPatterns.Flyweight.Concretes
{
    internal class CarGalleryFactory : ICarGalleryFactory
    {
        public ICarGallery CreateIstanbulBranch(string owner)
        {
            var carGallery = new CarGallery(city: "Istanbul", "Kadikoy", owner, 200);
            return carGallery;
        }

        public ICarGallery CreateParisBranch(string owner)
        {
            var carGallery = new CarGallery(city: "Paris", "Odeon", owner, 100);
            return carGallery;
        }
    }
}
