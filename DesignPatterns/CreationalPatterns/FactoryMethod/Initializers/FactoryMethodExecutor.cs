using Core.Interfaces;
using Core.Utils;
using DesignPatterns.Base;

namespace DesignPatterns.CreationalPatterns.FactoryMethodPatterns.Initializers
{
    public class FactoryMethodExecutor : BaseExecutor, IPatternExecutor
    {
        #region Class/Object Information

        private const string PatternName = "Factory Method";

        public string GetPatternName()
        {
            return PatternName;
        }

        #endregion Class/Object Information

        private readonly FactoryMethodTester _abstractFactoryTest = new();

        public void Execute()
        {
            GenericExecutor.ExecuteStandardTest(tester: _abstractFactoryTest, patternName: PatternName);
        }
    }
}