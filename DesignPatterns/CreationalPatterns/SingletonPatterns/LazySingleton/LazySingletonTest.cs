using Core;

namespace DesignPatterns.CreationalPatterns.SingletonPatterns.LazySingleton
{
    public sealed class LazySingletonTest: IPatternTester
    {
        private const string PatternName = "Lazy Singleton";
        public string GetPatternName()
        {
            return PatternName;
        }

        private static bool _isTestPassed = true;
        private const string ExpectedInstanceName = "Instance SN: 1.";

        public void Test()
        {
            Console.WriteLine(LazySingletonConsoleMessages.Information);
            var input = ConsoleExtension.ReadIntegerFromConsole();
            switch (input)
            {
                case 0:
                    break;
                case 1:
                    StartThreads();
                    PrintResults();
                    break;
                default:
                    Console.WriteLine(LazySingletonConsoleMessages.CommandNotFound);
                    Test();
                    break;
            }
        }

        private static void CreateAndCheckInstance()
        {
            var testInstanceName = LazySingleton.GetObject().GetName();
            Console.WriteLine(testInstanceName);
            if (!string.Equals(testInstanceName, ExpectedInstanceName))
            {
                _isTestPassed = false;
            }
        }

        private static void StartThreads()
        {
            Console.WriteLine(LazySingletonConsoleMessages.CountQuestion);
            var objectCountToGenerate = ConsoleExtension.ReadIntegerFromConsole();
            for (var i = 0; i < objectCountToGenerate; i++)
            {
                var thread = new Thread(CreateAndCheckInstance);
                thread.Start();
                Console.WriteLine($"\nThread Name: {thread.ManagedThreadId} started.");
            }
        }

        private static void PrintResults()
        {
            Console.WriteLine(_isTestPassed
                ? LazySingletonConsoleMessages.TestSucceeded
                : LazySingletonConsoleMessages.TestFailed);
        }
        
    }
}
