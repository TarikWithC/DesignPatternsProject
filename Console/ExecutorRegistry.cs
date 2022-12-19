using System.Text;
using DesignPatterns;
using DesignPatterns.CreationalPatterns.FactoryMethodPatterns.Initializers;
using DesignPatterns.CreationalPatterns.SingletonPatterns.Initializers;

namespace ConsoleApp
{
    public class ExecutorRegistry
    {
        private readonly int _serialNumber;
        public Dictionary<int, IPatternExecutor> Executors = new();
        public StringBuilder PatternNames = new();

        public ExecutorRegistry()
        {
            Executors.TryAdd(++_serialNumber, new SingletonExecutor());
            Executors.TryAdd(++_serialNumber, new FactoryMethodExecutor());
            SavePatternNames();
        }

        public void SavePatternNames()
        {
            foreach (var item in Executors)
            {
                PatternNames.AppendLine($"{item.Key}: {item.Value.GetPatternName()}");
            }
        }
    }
}
