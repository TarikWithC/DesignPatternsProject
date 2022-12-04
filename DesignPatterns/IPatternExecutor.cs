using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public interface IPatternExecutor
    {
        public void Execute();
        public string GetPatternName();
    }
}
