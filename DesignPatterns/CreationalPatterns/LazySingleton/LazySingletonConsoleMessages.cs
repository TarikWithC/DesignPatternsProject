using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Constants;

namespace DesignPatterns.CreationalPatterns.LazySingleton
{
    internal class LazySingletonConsoleMessages
    {
        internal const string? Information = "Welcome to lazy singleton.\n" +
                                             "0: Quit this menu.\n" +
                                             "1: Run test.";
        internal const string CountQuestion = "How many objects do you want to create?";
        internal const string TestSucceeded = "All test instances are the same. Some threads are different. Test succeeded.";
        internal const string TestFailed = "Some test instances are different. Test failed.";
        internal const string CommandNotFound = "Command couldn't be found. Please be sure that your input is valid.";
    }
}
