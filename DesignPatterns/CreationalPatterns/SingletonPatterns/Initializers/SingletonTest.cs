using Core.Extensions;
using DesignPatterns.CreationalPatterns.SingletonPatterns.Constants;
using DesignPatterns.CreationalPatterns.SingletonPatterns.Interfaces;

namespace DesignPatterns.CreationalPatterns.SingletonPatterns.Initializers
{
    public sealed class SingletonTest
    {

        private static bool _isTestPassed = true;
        private const string ExpectedInstanceName = "Instance SN: 1.";

        public void Test(ISingleton singletonObject)
        {
            Console.WriteLine(SingletonConsoleMessages.Information(singletonObject.GetPatternName()));
            var input = ConsoleExtension.ReadIntegerFromConsole();
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
            var objectCountToGenerate = ConsoleExtension.ReadIntegerFromConsole();
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
