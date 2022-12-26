namespace DesignPatterns.StructuralPatterns.Flyweight.Abstractions
{
    internal interface ICarGalleryFactory
    {
        ICarGallery CreateIstanbulBranch(string owner);

        ICarGallery CreateParisBranch(string owner);
    }
}