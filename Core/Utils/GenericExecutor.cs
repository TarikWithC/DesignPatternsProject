using Core.Helpers;
using Core.Interfaces;
using Core.Constants;

namespace Core.Utils
{
    public class GenericExecutor
    {
        public void ExecuteStandardTest(IPatternTester tester, string patternName)
        {
            ConsolePrinter.PrintPatternWelcomeMessage(patternName: patternName);
            var choice = ConsoleReader.ReadIntegerFromConsole();
            switch (choice)
            {
                case 0:
                    return;
                case 1:
                    tester.Test();
                    break;
                default:
                    Console.WriteLine(ConsoleMessages.CommandNotFound);
                    ExecuteStandardTest(tester, patternName);
                    break;
            }
        }
    }
}
