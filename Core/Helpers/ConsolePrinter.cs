namespace Core.Helpers
{
    public static class ConsolePrinter
    {
        public static void PrintPatternWelcomeMessage(string patternName)
        {
            Console.WriteLine($"Welcome to {patternName} Design Pattern:\n" +
                              "0: Quit this menu.\n" +
                              "1: Run test.");
        }
    }
}