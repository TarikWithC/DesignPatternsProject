using Core.Extensions;
using DesignPatterns.CreationalPatterns.SingletonPatterns.Constants;
using DesignPatterns.CreationalPatterns.SingletonPatterns.Interfaces;
using DesignPatterns.CreationalPatterns.SingletonPatterns.Types;

namespace DesignPatterns.CreationalPatterns.SingletonPatterns.Initializers
{
    public class SingletonExecutor: IPatternExecutor
    {
        #region Class/Object Information
        private const string PatternName = "Singleton";
        public string GetPatternName()
        {
            return PatternName;
        }
        #endregion


        private readonly SingletonTest _singletonTester = new ();
        private static readonly Dictionary<int, ISingleton> SingletonDictionary = new();
        private static int _serialNumber;

        public SingletonExecutor()
        {
            RegisterPatterns();
        }

        public static void RegisterPatterns()
        {
            SingletonDictionary.Add(++_serialNumber, Singleton.Instance);
            SingletonDictionary.Add(++_serialNumber, LazySingleton.Instance);
            SingletonDictionary.Add(++_serialNumber, ThreadSafeLazySingleton.Instance);
            SingletonDictionary.Add(++_serialNumber, NestedLazySingleton.Instance);
            SingletonDictionary.Add(++_serialNumber, DotNetLazySingleton.Instance);
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

            if (choice == 0)
                return;
            if (SingletonDictionary.ContainsKey(choice))
            {
                SingletonDictionary.TryGetValue(choice, out ISingleton singletonObject);
                _singletonTester.Test(singletonObject);
            }
            else
            {
                Console.WriteLine(SingletonConsoleMessages.CommandNotFound);
            }
        }
    }
}
