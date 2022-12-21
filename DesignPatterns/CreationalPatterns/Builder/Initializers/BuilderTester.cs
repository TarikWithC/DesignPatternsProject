
using Core.Helpers;
using Core.Interfaces;
using DesignPatterns.CreationalPatterns.Builder.Abstractions;
using DesignPatterns.CreationalPatterns.Builder.Concretes;
using DesignPatterns.CreationalPatterns.Builder.Constants;

namespace DesignPatterns.CreationalPatterns.Builder.Initializers
{
    internal class BuilderTester : IPatternTester
    {
        private readonly IComputerBuilder _builder = new Computer.ComputerBuilder("Msi");

        public void Test()
        {
            Console.WriteLine(BuilderConsoleMessages.Welcome);

            Console.WriteLine(BuilderConsoleMessages.CpuQuestion);
            var isCpuWanted = ConsoleReader.ReadYesOrNoFromConsole();

            Console.WriteLine(BuilderConsoleMessages.GpuQuestion);
            var isGpuWanted = ConsoleReader.ReadYesOrNoFromConsole();

            Console.WriteLine(BuilderConsoleMessages.HardDriveQuestion);
            var isHardDriveWanted = ConsoleReader.ReadYesOrNoFromConsole();

            Console.WriteLine(BuilderConsoleMessages.RamQuestion);
            var isRamWanted = ConsoleReader.ReadYesOrNoFromConsole();

            if (isCpuWanted)
                _builder.BuildCpu();
            if (isGpuWanted)
                _builder.BuildGpu();
            if (isHardDriveWanted)
                _builder.BuildHardDrive();
            if (isRamWanted)
                _builder.BuildRam();

            _builder.Build();
        }
    }
}
