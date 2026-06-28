using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Search1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Insert integers seperated by ,");
                string Data = Console.ReadLine();
                List<string> result = Data.Split(',').ToList();
                List<int> compareList = new List<int>();

                for (int i = 0; i < result.Count; i++)
                {
                    try
                    {
                     int no = int.Parse(result[i]);
                        if (compareList.Contains(no))
                        {
                            Console.WriteLine($"The Number dulicated {no}");
                           
                        }
                        else {
                            compareList.Add(no);

                        }

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"The List contains non integer {result[i]}");
                        break;
                    }
                    
                }
                    
                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

        }
    }
}
