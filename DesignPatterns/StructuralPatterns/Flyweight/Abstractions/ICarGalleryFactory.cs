using DesignPatterns.StructuralPatterns.Flyweight.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralPatterns.Flyweight.Abstractions
{
    internal interface ICarGalleryFactory
    {
        ICarGallery CreateIstanbulBranch(string owner);
        ICarGallery CreateParisBranch(string owner);
    }
}
