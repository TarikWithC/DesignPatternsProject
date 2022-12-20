using Core.Interfaces;
using DesignPatterns.CreationalPatterns.FactoryMethodPatterns.Company.Abstractions;

namespace DesignPatterns.CreationalPatterns.FactoryMethodPatterns.Initializers
{
    public class FactoryMethodExecutor : IPatternExecutor
    {
        private const string PatternName = "Factory Method";
      
        public void Execute()
        {
           
        }

        public string GetPatternName()
        {
            return PatternName;
        }
    }
}