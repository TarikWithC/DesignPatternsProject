using Core;

namespace DesignPatterns.CreationalPatterns.Singleton
{
    public class SingletonTest: ISingletonTest
    {
        public SingletonTest()
        {
        }

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
            var isTestPassed = true;
            Console.WriteLine(SingletonConsoleMessages.CountQuestion);

            var objectCountToGenerate = ConsoleExtension.ReadIntegerFromConsole();

            var previousObjectName = Singleton.GetObject().GetName();
            for (var i = 0; i < objectCountToGenerate; i++)
            {
                var currentObjectName = Singleton.GetObject().GetName();
                if (previousObjectName != currentObjectName)
                    isTestPassed = false;
                previousObjectName = currentObjectName;
                Console.WriteLine(currentObjectName);
            }

            Console.WriteLine(isTestPassed
                ? SingletonConsoleMessages.TestSucceeded
                : SingletonConsoleMessages.TestFailed);
        }

        private static void CheckIfObjectsAreSame()
        {
            var firstObject = Singleton.GetObject();
            var secondObject = Singleton.GetObject();
            if(firstObject == secondObject)
                Console.WriteLine(SingletonConsoleMessages.TestSucceeded);
            else
                Console.WriteLine(SingletonConsoleMessages.TestFailed);
        }


    }
}
