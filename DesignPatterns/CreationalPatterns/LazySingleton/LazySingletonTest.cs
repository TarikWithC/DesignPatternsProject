
using Core;
using DesignPatterns.CreationalPatterns.Singleton;

namespace DesignPatterns.CreationalPatterns.LazySingleton
{
    public class LazySingletonTest: ILazySingleton
    {
        private static bool _isTestPassed = true;
        public void Test()
        {
            Console.WriteLine(LazySingletonConsoleMessages.Information);
            var input = ConsoleExtension.ReadIntegerFromConsole();
            switch (input)
            {
                case 0:
                    break;
                case 1:
                    InitializeSingletonObjects();
                    break;
                default:
                    Console.WriteLine(LazySingletonConsoleMessages.CommandNotFound);
                    Test();
                    break;
            }
        }
        
        private static void InitializeSingletonObjects()
        {
            
            Console.WriteLine(LazySingletonConsoleMessages.CountQuestion);
            var objectCountToGenerate = ConsoleExtension.ReadIntegerFromConsole();
            var previousObjectName = LazySingleton.GetObject().GetName();
            for (var i = 0; i < objectCountToGenerate; i++)
            {
                InitializeThreads();
                var currentObjectName = LazySingleton.GetObject().GetName();
                if (previousObjectName != currentObjectName)
                    _isTestPassed = false;
                previousObjectName = currentObjectName;
                Console.WriteLine(currentObjectName);
                Thread.Sleep(0);
            }

            Console.WriteLine(_isTestPassed
                ? LazySingletonConsoleMessages.TestSucceeded
                : LazySingletonConsoleMessages.TestFailed);
        }

        public static void InitializeThreads()
        {
            var thread = new Thread(InitializeSingletonObjects);
            Console.WriteLine($"\nThread Name: {thread.ManagedThreadId}");
        }
    }
}
