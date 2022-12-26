using Core.Interfaces;
using DesignPatterns.CreationalPatterns.AbstractFactory.Initializers;
using DesignPatterns.CreationalPatterns.Builder.Initializers;
using DesignPatterns.CreationalPatterns.FactoryMethod.Initializers;
using DesignPatterns.CreationalPatterns.Prototype.Initializers;
using DesignPatterns.CreationalPatterns.SingletonPatterns.Initializers;
using DesignPatterns.StructuralPatterns.Flyweight.Initializers;
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
            Executors.TryAdd(++_serialNumber, new PrototypeExecutor());
            Executors.TryAdd(++_serialNumber, new BuilderExecutor());
            Executors.TryAdd(++_serialNumber, new FlyweightExecutor());
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