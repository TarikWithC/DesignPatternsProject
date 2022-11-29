using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Core;
using DesignPatterns.Patterns.CreationalPatterns.Singleton;

namespace CreationalPatterns.Singleton
{
    public class SingletonTest: PatternTestBase
    {

        public SingletonTest()
        {
            Test();
        }

        private void Test()
        {
            Console.WriteLine(SingletonConsoleMessages.InformationMessage);
            var input = ConsoleExtension.ReadStringFromConsole();
            switch (input)
            {
                case "0":
                    break;
                case "1":
                    InitializeSingletonObjects();
                    break;
                case "2":
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
                ? SingletonConsoleMessages.TestSucceded
                : SingletonConsoleMessages.TestFailed);
        }

        private static void CheckIfObjectsAreSame()
        {
            var firstObject = Singleton.GetObject();
            var secondObject = Singleton.GetObject();
            if(firstObject == secondObject)
                Console.WriteLine(SingletonConsoleMessages.TestSucceded);
            else
                Console.WriteLine(SingletonConsoleMessages.TestFailed);
        }


    }
}
