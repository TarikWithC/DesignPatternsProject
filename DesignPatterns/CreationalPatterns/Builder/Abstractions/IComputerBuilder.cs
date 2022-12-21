using DesignPatterns.CreationalPatterns.Builder.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
