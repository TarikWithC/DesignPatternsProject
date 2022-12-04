using System.Text;
using DesignPatterns;
using DesignPatterns.CreationalPatterns.SingletonPatterns;
using DesignPatterns.CreationalPatterns.SingletonPatterns.Initiliazers;

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
