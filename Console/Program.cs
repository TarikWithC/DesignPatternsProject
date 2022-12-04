using Core;
using Core.Extensions;
using DesignPatterns;

namespace ConsoleApp;
internal class Program
{
    private static bool _flag = true;
    private static readonly PatternTestRegistry PatternTestRegistry = new();
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
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine(ConsoleMenuMessages.MainInfo + PatternTestRegistry.PatternNames);
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        var choice = ConsoleExtension.ReadIntegerFromConsole();

        if (choice == 0)
            _flag = false;

        var executors = PatternTestRegistry.Executors;
        if (executors.ContainsKey(choice))
        {
            executors.TryGetValue(choice, out IPatternExecutor? executor);
            executor?.Execute();
        }
        else
        {
            Console.WriteLine(ConsoleMenuMessages.InvalidValue);
        }
    }
}
