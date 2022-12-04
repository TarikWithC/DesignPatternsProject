using System.Text;
using Core.Extensions;
using DesignPatterns.CreationalPatterns.SingletonPatterns.Constants;
using DesignPatterns.CreationalPatterns.SingletonPatterns.Entities;
using DesignPatterns.CreationalPatterns.SingletonPatterns.Interfaces;

namespace DesignPatterns.CreationalPatterns.SingletonPatterns.Initiliazers
{
    public class SingletonExecutor: IPatternExecutor
    {
        private const string PatternName = "Singleton";
        public string GetPatternName()
        {
            return PatternName;
        }

        private SingletonTest singletonTester = new SingletonTest();
        private static Dictionary<int, ISingleton> SingletonDictionary = new();
        private static int serialNumber;

        public SingletonExecutor()
        {
            RegisterPatterns();
        }

        public static void RegisterPatterns()
        {
            SingletonDictionary.Add(++serialNumber, Singleton.Instance);
            SingletonDictionary.Add(++serialNumber, LazySingleton.Instance);
            SingletonDictionary.Add(++serialNumber, ThreadSafeLazySingleton.Instance);
            SingletonDictionary.Add(++serialNumber, NestedLazySingleton.Instance);
            SingletonDictionary.Add(++serialNumber, DotNetLazySingleton.Instance);
        }

        public void PrintPatternNames()
        {
            foreach (var item in SingletonDictionary)
            {
                Console.WriteLine($"{item.Key}: {item.Value.GetPatternName()}");
            }
        }
        public void Execute()
        {
            Console.WriteLine(SingletonConsoleMessages.MainInformation);
            PrintPatternNames();
            var choice = ConsoleExtension.ReadIntegerFromConsole();
            Console.ForegroundColor = ConsoleColor.Cyan;
            if (choice == 0)
                return;
            if (SingletonDictionary.ContainsKey(choice))
            {
                SingletonDictionary.TryGetValue(choice, out ISingleton singletonObject);
                singletonTester.Test(singletonObject);
            }
            else
            {
                Console.WriteLine(SingletonConsoleMessages.CommandNotFound);
            }
        }
    }
}
