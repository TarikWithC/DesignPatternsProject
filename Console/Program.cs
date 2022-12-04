using Core.Extensions;
using DesignPatterns;

namespace ConsoleApp;
internal class Program
{
    private static bool _flag = true;
    private static readonly ExecutorRegistry PatternTestRegistry = new();
    private static void Main()
    {
        try
        {
            while (_flag)
            {
                Run();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    private static void Run()
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine(ConsoleMenuMessages.MainInfo + PatternTestRegistry.PatternNames);
        var choice = ConsoleExtension.ReadIntegerFromConsole();

        var executors = PatternTestRegistry.Executors;
        if (choice == 0)
            _flag = false;
        else if (executors.ContainsKey(choice))
        {
            executors.TryGetValue(choice, out IPatternExecutor? executor);
            executor?.Execute();
        }
        else
        {
            var currentColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(ConsoleMenuMessages.InvalidValue);
            Console.ForegroundColor = currentColor;
        }
    }
}
