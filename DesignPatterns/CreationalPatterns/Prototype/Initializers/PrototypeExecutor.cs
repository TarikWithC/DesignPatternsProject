using Core.Interfaces;
using DesignPatterns.Base;

namespace DesignPatterns.CreationalPatterns.Prototype.Initializers
{
    public class PrototypeExecutor : BaseExecutor, IPatternExecutor
    {
        #region Class/Object Information

        private const string PatternName = "Prototype";

        public string GetPatternName()
        {
            return PatternName;
        }

        #endregion Class/Object Information

        private readonly PrototypeTester _prototypeTester = new();

        public void Execute()
        {
            GenericExecutor.ExecuteStandardTest(tester: _prototypeTester, patternName: PatternName);
        }
    }
}