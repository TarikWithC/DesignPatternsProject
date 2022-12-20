using Core.Extensions;
using DesignPatterns.Constants;
using DesignPatterns.CreationalPatterns.AbstractFactoryPatterns.Constants;

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

        private readonly AbstractFactoryTest _abstractFactoryTest = new ();
        public void Execute()
        {
            Console.WriteLine(AbstractFactoryMessages.MainInformation);
            var choice = ConsoleExtension.ReadIntegerFromConsole();
            switch (choice)
            {
                case 0:
                    return;
                case 1:
                    _abstractFactoryTest.Test();
                    break;
                default:
                    Console.WriteLine(ConsoleMessages.CommandNotFound);
                    Execute();
                    break;
            }
        }
    }
}
