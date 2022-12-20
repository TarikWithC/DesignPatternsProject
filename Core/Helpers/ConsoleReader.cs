namespace Core.Helpers
{
    public static class ConsoleReader
    {
        public static string ReadStringFromConsole()
        {
            try
            {
                var input = Console.In.ReadLine();
                if (input != null)
                {
                    return input;
                }
                var currentColor = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Please enter a value.");
                Console.ForegroundColor = currentColor;
                return ReadStringFromConsole();
            }
            catch (Exception ex)
            {
                throw new Exception($"Program failed. Exception: {ex.Message}");
            }
        }

        public static int ReadIntegerFromConsole()
        {
            try
            {
                var input = Convert.ToInt32(ReadStringFromConsole());
                return input;
            }
            catch (FormatException)
            {
                var currentColor = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Please enter a number.");
                Console.ForegroundColor = currentColor;
                return ReadIntegerFromConsole();
            }
            catch (Exception ex)
            {
                throw new Exception($"Program failed. Exception: {ex.Message}");
            }
        }

        //TODO public static int ReadPositiveIntegerFromConsole()
    }
}