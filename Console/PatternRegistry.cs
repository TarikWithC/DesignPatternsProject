using DesignPatterns.Patterns;
using DesignPatterns.Patterns.CreationalPatterns.Singleton;

namespace ConsoleApp
{
    public class TestRegistry
    {
        private readonly int _serialNumber = 0;
        public Dictionary<int, IPatternTester> Tests = new();

        public TestRegistry()
        {
            Tests.TryAdd(++_serialNumber, new SingletonTest());
        }
    }
}
