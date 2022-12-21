
using DesignPatterns.CreationalPatterns.Builder.Abstractions;

using DesignPatterns.CreationalPatterns.Builder.Concretes.Parts;

namespace DesignPatterns.CreationalPatterns.Builder.Concretes
{
    public class Computer
    {
        private Cpu cpu;
        private Gpu gpu;
        private HardDrive hardDrive;
        private Ram ram;
        private string _name;

        public Computer()
        {

        }

        

        public class ComputerBuilder : IComputerBuilder
        {
           
            private bool _hasCpu;
            private bool _hasGpu;
            private bool _hasHardDrive;
            private bool _hasRam;
            private readonly string _name;
            private Computer? _computer;

            public ComputerBuilder(string name)
            {
                this._name = name;
            }
            public IComputerBuilder BuildCpu()
            {
                _hasCpu = true;
                return this;
            }
            public IComputerBuilder BuildGpu()
            {
                _hasGpu = true;
                return this;
            }
            public IComputerBuilder BuildHardDrive()
            {
                _hasHardDrive = true;
                return this;
            }
            public IComputerBuilder BuildRam()
            {
                _hasRam = true;
                return this;
            }
            public Computer Build()
            {
                _computer = new Computer
                {
                    _name = this._name
                };

                if (_hasCpu)
                {
                    Cpu cpu = new();
                    _computer.cpu = cpu;
                }

                if (_hasGpu)
                {
                    Gpu gpu = new();
                    _computer.gpu = gpu;
                }

                if (_hasHardDrive)
                {
                    HardDrive drive = new();
                    _computer.hardDrive = drive;
                }

                if (_hasRam)
                {
                    Ram ram = new();
                    _computer.ram = ram;
                }

                PrintInfo();
                return _computer;
            }

            public void PrintInfo()
            {
                Console.WriteLine($"\nPC has been built.\n" +
                                  $"PC has CPU: {_hasGpu}\n" +
                                  $"PC has GPU: {_hasGpu}\n" +
                                  $"PC has Hard Drive: {_hasHardDrive}\n" +
                                  $"PC has RAM: {_hasRam}\n");
            }
        }

        
    }
}
