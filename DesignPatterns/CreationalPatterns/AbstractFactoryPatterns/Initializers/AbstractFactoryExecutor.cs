using Core.Helpers;
using DesignPatterns.Constants;

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
            ConsolePrinter.PrintPatternWelcomeMessage(patternName: PatternName);
            var choice = ConsoleReader.ReadIntegerFromConsole();
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
