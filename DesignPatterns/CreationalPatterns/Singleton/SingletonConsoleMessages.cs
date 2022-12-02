
namespace DesignPatterns.CreationalPatterns.Singleton
{
    internal class SingletonConsoleMessages
    {
        internal const string Information = "There are '2' tests for Basic Singleton Design Pattern\n" +
                                                   "1: Initializes multiple singleton objects with serial numbers.\n" +
                                                   "2: Initializes two singleton objects and checks if they are really same objects.\n" +
                                                   "Please press 1 or 2 two start testing this design pattern, press 0 to exit this menu.";

        internal const string CountQuestion = "How many objects do you want to create?";

        internal const string TestSucceeded = "All test instances are the same. Test succeeded.";

        internal const string TestFailed = "Some test instances are different. Test failed.";

        internal const string TestNotFound = "Test couldn't be found. Please be sure that your input is valid.";

    }
}
