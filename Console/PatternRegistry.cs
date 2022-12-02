using DesignPatterns;
using DesignPatterns.CreationalPatterns.LazySingleton;
using DesignPatterns.CreationalPatterns.Singleton;

namespace ConsoleApp
{
    public class TestRegistry
    {
        private readonly int _serialNumber;
        public Dictionary<int, IPatternTester> Tests = new();

        public TestRegistry()
        {
            Tests.TryAdd(++_serialNumber, new SingletonTest());
            Tests.TryAdd(++_serialNumber, new LazySingletonTest());
        }
    }
}
