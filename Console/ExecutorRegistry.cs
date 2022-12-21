using Core.Interfaces;
using DesignPatterns.CreationalPatterns.AbstractFactoryPatterns.Initializers;
using DesignPatterns.CreationalPatterns.FactoryMethodPatterns.Initializers;
using DesignPatterns.CreationalPatterns.SingletonPatterns.Initializers;
using System.Text;

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
            Executors.TryAdd(++_serialNumber, new AbstractFactoryExecutor());
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