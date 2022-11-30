using Core;
using DesignPatterns.Patterns;

namespace ConsoleApp;
internal class Program
{
    private static bool flag = true;
    private static readonly TestRegistry TestRegistry = new();
    private static void Main()
    {
        while (flag)
        {
            Run();
        }
    }

    private static void Run()
    {
        Console.WriteLine(ConsoleMenuMessages.MainInfo);
        var choice = ConsoleExtension.ReadIntegerFromConsole();

        //TODO remove if else, improve code quality for choosing a pattern or test.
        if (choice == 0)
        {
            flag = false;
        }
        if (choice == 1)
        {
            TestRegistry.Tests.TryGetValue(1, out IPatternTester tester);
            tester.Test();
        }
        else
        {
            Console.WriteLine(ConsoleMenuMessages.InvalidValue);
        }
    }
}
