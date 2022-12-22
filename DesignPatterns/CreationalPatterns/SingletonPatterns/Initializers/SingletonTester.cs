using Core.Helpers;
using DesignPatterns.CreationalPatterns.SingletonPatterns.Abstractions;
using DesignPatterns.CreationalPatterns.SingletonPatterns.Constants;

namespace DesignPatterns.CreationalPatterns.SingletonPatterns.Initializers
{
    public sealed class SingletonTester
    {
        private static bool _isTestPassed = true;
        private const string ExpectedInstanceName = "Instance SN: 1.";

        public void Test(ISingleton singletonObject)
        {
            ConsolePrinter.PrintPatternWelcomeMessage(singletonObject.GetPatternName());
            var input = ConsoleReader.ReadIntegerFromConsole();
            switch (input)
            {
                case 0:
                    break;

                case 1:
                    StartThreads(singletonObject);
                    PrintResults();
                    break;

                default:
                    Console.WriteLine(SingletonConsoleMessages.CommandNotFound);
                    Test(singletonObject);
                    break;
            }
        }

        private static void CreateAndCheckInstance(ISingleton singletonObject)
        {
            var testInstanceName = singletonObject.GetName();
            Console.WriteLine(testInstanceName);
            if (!string.Equals(testInstanceName, ExpectedInstanceName))
            {
                _isTestPassed = false;
            }
        }

        private static void StartThreads(ISingleton singletonObject)
        {
            Console.WriteLine(SingletonConsoleMessages.CountQuestion);
            var objectCountToGenerate = ConsoleReader.ReadIntegerFromConsole();
            for (var i = 0; i < objectCountToGenerate; i++)
            {
                var thread = new Thread(() => CreateAndCheckInstance(singletonObject));
                thread.Start();
                Console.WriteLine($"\nThread Name: {thread.ManagedThreadId} started.");
            }
        }

        private static void PrintResults()
        {
            Console.WriteLine(_isTestPassed
                ? SingletonConsoleMessages.TestSucceeded
                : SingletonConsoleMessages.TestFailed);
        }
    }
}