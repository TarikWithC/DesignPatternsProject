using Core;
using Core.Extensions;

namespace DesignPatterns.CreationalPatterns.SingletonPatterns.Singleton
{
    public sealed class SingletonTest: IPatternTester
    {
        private const string PatternName = "Singleton";
        public string GetPatternName()
        {
            return PatternName;
        }

        private static bool _isTestPassed = true;

        public void Test()
        {
            Console.WriteLine(SingletonConsoleMessages.Information);
            var input = ConsoleExtension.ReadIntegerFromConsole();
            switch (input)
            {
                case 0:
                    break;
                case 1:
                    InitializeSingletonObjects();
                    break;
                case 2:
                    CheckIfObjectsAreSame();
                    break;
                default:
                    Console.WriteLine(SingletonConsoleMessages.TestNotFound);
                    Test();
                    break;
            }
        }

        private static void InitializeSingletonObjects()
        {
            Console.WriteLine(SingletonConsoleMessages.CountQuestion);

            var objectCountToGenerate = ConsoleExtension.ReadIntegerFromConsole();

            var previousObjectName = Singleton.GetObject().GetName();
            for (var i = 0; i < objectCountToGenerate; i++)
            {
                var currentObjectName = Singleton.GetObject().GetName();
                if (previousObjectName != currentObjectName)
                    _isTestPassed = false;
                previousObjectName = currentObjectName;
                Console.WriteLine(currentObjectName);
            }

            Console.WriteLine(_isTestPassed
                ? SingletonConsoleMessages.TestSucceeded
                : SingletonConsoleMessages.TestFailed);
        }

        private static void CheckIfObjectsAreSame()
        {
            var firstObject = Singleton.GetObject();
            var secondObject = Singleton.GetObject();
            if (firstObject != secondObject)
                _isTestPassed = false;

            Console.WriteLine(_isTestPassed
                ? SingletonConsoleMessages.TestSucceeded
                : SingletonConsoleMessages.TestFailed);
        }


    }
}
