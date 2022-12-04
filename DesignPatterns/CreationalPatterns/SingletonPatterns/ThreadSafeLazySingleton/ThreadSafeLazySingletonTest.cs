using Core;
using Core.Extensions;

namespace DesignPatterns.CreationalPatterns.SingletonPatterns.ThreadSafeLazySingleton
{
    public sealed class ThreadSafeLazySingletonTest: IPatternTester
    {
        private const string PatternName = "Thread Safe Lazy Singleton";
        public string GetPatternName()
        {
            return PatternName;
        }

        private static bool _isTestPassed = true;
        private const string ExpectedInstanceName = "Instance SN: 1.";

        public void Test()
        {
            Console.WriteLine(ThreadSafeLazySingletonMessages.Information);
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
                    Console.WriteLine(ThreadSafeLazySingletonMessages.CommandNotFound);
                    Test();
                    break;
            }
        }

        private static void CreateAndCheckInstance()
        {
            var testInstanceName = ThreadSafeLazySingleton.GetObject().GetName();
            Console.WriteLine(testInstanceName);
            if (!string.Equals(testInstanceName, ExpectedInstanceName))
            {
                _isTestPassed = false;
            }
        }

        private static void StartThreads()
        {
            Console.WriteLine(ThreadSafeLazySingletonMessages.CountQuestion);
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
                ? ThreadSafeLazySingletonMessages.TestSucceeded
                : ThreadSafeLazySingletonMessages.TestFailed);
        }
        
    }
}
