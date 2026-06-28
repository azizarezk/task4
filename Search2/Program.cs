using System.Security.AccessControl;
using static System.Net.Mime.MediaTypeNames;

namespace Search2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Insert string");
                string Data = Console.ReadLine();

                List<char> vowels = new List<char> { 'A', 'E', 'I', 'O', 'U'};

                foreach (char c in Data.ToUpper())
                {
                    if (vowels.Contains(c))
                    {
                        Console.WriteLine($"The string contains {c}");
                        break;
                    }
                }
                Console.WriteLine($"The string not contains vowels");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
