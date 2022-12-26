using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Interfaces;
using DesignPatterns.Base;

namespace DesignPatterns.StructuralPatterns.Flyweight.Initializers
{
    public class FlyweightExecutor : BaseExecutor, IPatternExecutor
    {
        #region Class/Object Information

        private const string PatternName = "Flyweight";
        private readonly FlyweightTester _flyweightTester = new();

        public string GetPatternName()
        {
            return PatternName;
        }

        #endregion Class/Object Information
        public void Execute()
        {
            GenericExecutor.ExecuteStandardTest(tester: _flyweightTester, patternName: PatternName);
        }

    }
}
