using Core.Interfaces;
using DesignPatterns.Base;

namespace DesignPatterns.CreationalPatterns.AbstractFactory.Initializers
{
    public sealed class AbstractFactoryExecutor : BaseExecutor, IPatternExecutor
    {
        #region Class/Object Information

        private const string PatternName = "Abstract Factory";

        public string GetPatternName()
        {
            return PatternName;
        }

        #endregion Class/Object Information

        private readonly AbstractFactoryTester _abstractFactoryTest = new();

        public void Execute()
        {
            GenericExecutor.ExecuteStandardTest(tester: _abstractFactoryTest, patternName: PatternName);
        }
    }
}