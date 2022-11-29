
namespace DesignPatterns.Core
{
    public static class ConsoleExtension
    {
        public static string ReadStringFromConsole()
        {
            try
            {
                var input = Console.In.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Please enter a valid value.");
                    ReadStringFromConsole();
                }
                return input;
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
                throw new FormatException($"Please enter a valid number.");
            }
            catch (Exception ex)
            {
                throw new Exception($"Program failed. Exception: {ex.Message}");
            }
        }
    }
}
