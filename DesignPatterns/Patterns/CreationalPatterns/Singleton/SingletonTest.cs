using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Core;

namespace CreationalPatterns.Singleton
{
    public class SingletonTest: PatternTestBase
    {
        public SingletonTest()
        {
            Console.WriteLine(CtorMessage);

            var input = ConsoleExtension.ReadStringFromConsole();
            TestPicker(input);
        }


        private void TestPicker(string input)
        {
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
                    Console.WriteLine("Test couldn't be found. Please be sure that your input is valid.");
                    TestPicker(input);
                    break;
            }
        }

        public void InitializeSingletonObjects()
        {
            for (var i = 0; i < 10; i++)
            {
                var obj = Singleton.GetObject();
                Console.WriteLine(obj.GetName());
            } 
        }

        public void CheckIfObjectsAreSame()
        {
            var firstObject = Singleton.GetObject();
            var secondObject = Singleton.GetObject();
            if(firstObject == secondObject)
                Console.WriteLine("Two objects are the same, test passed.");
            else
                Console.WriteLine("Two objects are different, test failed.");
        }


        private const string CtorMessage = "There are '2' tests for Basic Singleton Design Pattern\n" +
                                          "1: Initializes multiple singleton objects with serial numbers.\n" +
                                          "2: Initializes two singleton objects and checks if they are really same objects.\n" +
                                          "Please press 1 or 2 two start testing this design pattern, press 0 to exit this menu.";
    }
}
