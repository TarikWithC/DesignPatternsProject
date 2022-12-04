using Core;

namespace DesignPatterns.CreationalPatterns.SingletonPatterns.NestedLazySingleton
{
    public sealed class NestedLazySingletonTest: IPatternTester
    {
        private const string PatternName = "Nested Lazy Singleton";
        public string GetPatternName()
        {
            return PatternName;
        }

        private static bool _isTestPassed = true;
        private const string ExpectedInstanceName = "Instance SN: 1.";

        public void Test()
        {
            Console.WriteLine(NestedLazySingletonConsoleMessages.Information);
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
                    Console.WriteLine(NestedLazySingletonConsoleMessages.CommandNotFound);
                    Test();
                    break;
            }
        }

        private static void CreateAndCheckInstance()
        {
            var testInstanceName = NestedLazySingleton.Instance.GetName();
            Console.WriteLine(testInstanceName);
            if (!string.Equals(testInstanceName, ExpectedInstanceName))
            {
                _isTestPassed = false;
            }
        }

        private static void StartThreads()
        {
            Console.WriteLine(NestedLazySingletonConsoleMessages.CountQuestion);
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
                ? NestedLazySingletonConsoleMessages.TestSucceeded
                : NestedLazySingletonConsoleMessages.TestFailed);
        }
        
    }
}
