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