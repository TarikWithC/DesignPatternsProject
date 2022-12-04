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
        Console.WriteLine(ConsoleMenuMessages.MainInfo + PatternTestRegistry.PatternNames);
        var choice = ConsoleExtension.ReadIntegerFromConsole();

        if (choice == 0)
            _flag = false;

        var tests = PatternTestRegistry.Tests;
        if (tests.ContainsKey(choice))
        {
            tests.TryGetValue(choice, out IPatternTester? tester);
            tester?.Test();
        }
        else
        {
            Console.WriteLine(ConsoleMenuMessages.InvalidValue);
        }
    }
}
