using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Interfaces;
using DesignPatterns.Base;

namespace DesignPatterns.StructuralPatterns.Adapter.Initializers
{
    public class AdapterExecutor : BaseExecutor, IPatternExecutor
    {
        public void Execute()
        {
            throw new NotImplementedException();
        }

        public string GetPatternName()
        {
            throw new NotImplementedException();
        }
    }
}
