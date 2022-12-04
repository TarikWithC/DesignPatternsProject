
namespace Core.Extensions
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
                    Console.WriteLine("Please enter a value.");
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
                Console.WriteLine("Please enter a number.");
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
