using DesignPatterns.CreationalPatterns.Builder.Concretes;

namespace DesignPatterns.CreationalPatterns.Builder.Abstractions
{
    public interface IComputerBuilder
    {
        public Computer Build();

        public IComputerBuilder BuildCpu();

        public IComputerBuilder BuildGpu();

        public IComputerBuilder BuildHardDrive();

        public IComputerBuilder BuildRam();
    }
}