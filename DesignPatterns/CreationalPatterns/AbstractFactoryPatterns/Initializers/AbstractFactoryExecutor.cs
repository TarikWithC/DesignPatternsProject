using Core.Interfaces;
using Core.Utils;

namespace DesignPatterns.CreationalPatterns.AbstractFactoryPatterns.Initializers
{
    public sealed class AbstractFactoryExecutor : IPatternExecutor
    {
        #region Class/Object Information
        private const string PatternName = "Abstract Factory";
        public string GetPatternName()
        {
            return PatternName;
        }
        #endregion Class/Object Information

        private readonly AbstractFactoryTester _abstractFactoryTest = new ();
        private readonly GenericExecutor _genericExecutor = new ();
        public void Execute()
        {
            _genericExecutor.ExecuteStandardTest(tester: _abstractFactoryTest, patternName: PatternName);
        }
    }
}
