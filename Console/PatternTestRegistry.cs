using System.Text;
using DesignPatterns;
using DesignPatterns.CreationalPatterns.SingletonPatterns.LazySingleton;
using DesignPatterns.CreationalPatterns.SingletonPatterns.NestedLazySingleton;
using DesignPatterns.CreationalPatterns.SingletonPatterns.Singleton;
using DesignPatterns.CreationalPatterns.SingletonPatterns.ThreadSafeLazySingleton;

namespace ConsoleApp
{
    public class PatternTestRegistry
    {
        private readonly int _serialNumber;
        public Dictionary<int, IPatternTester> Tests = new();
        public StringBuilder PatternNames = new();

        public PatternTestRegistry()
        {
            Tests.TryAdd(++_serialNumber, new SingletonTest());
            Tests.TryAdd(++_serialNumber, new LazySingletonTest());
            Tests.TryAdd(++_serialNumber, new ThreadSafeLazySingletonTest());
            Tests.TryAdd(++_serialNumber, new NestedLazySingletonTest());
            SavePatternNames();
        }

        public void SavePatternNames()
        {
            foreach (var item in Tests)
            {
                PatternNames.AppendLine($"{item.Key}: {item.Value.GetPatternName()}");
            }
        }
    }
}
