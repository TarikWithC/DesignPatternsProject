namespace DesignPatterns.CreationalPatterns.SingletonPatterns.Constants
{
    internal class SingletonConsoleMessages
    {
        internal const string MainInformation = "Choose one of the following Singleton Patterns:\n" +
                                                "0: Quit this menu.";

        internal static string Information(string patternName)
        {
            return $"\nWelcome to {patternName} Design Pattern.\n" +
                   "0: Quit this menu.\n" +
                   "1: Run test.";
        } 
        internal const string CountQuestion = "How many objects do you want to create?";
        internal const string TestSucceeded = "All test instances are the same. Some threads are different. Test succeeded.";
        internal const string TestFailed = "Some test instances are different. Test failed.";
        internal const string CommandNotFound = "Command couldn't be found. Please be sure that your input is valid.";
    }
}
