using System;

namespace DesignPatterns.Main;
internal class Program
{
    //TODO program should continue after completing a task.
    private static readonly PatternRegistry Patterns = new();
    private static void Main()
    {
        //TODO move constant messages to a class
        Console.WriteLine("Current Design Patterns Are:\n" +
                          "Singleton: 1");

        var choice = Convert.ToInt32(Console.ReadLine());

        //TODO remove if else, improve code quality for choosing a pattern or test.
        if (choice == 1)
        {
            //TODO improve registry system
            var _ =  Patterns.SingletonTester;
        }
        else
        {
            Console.WriteLine("Please enter a valid value.");
            Main();
        }
    }
}
