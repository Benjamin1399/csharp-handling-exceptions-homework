using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] test = new int[] { 1, 2, 3, 4, 5 };

            for (int i = 0; i <= test.Length; i++)
            {
                try
                {
                    Console.WriteLine(test[i]);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error occurred: {ex.Message}");
                    LogToFile(ex);
                }
            }
        }

        private static void LogToFile(Exception ex)
        {
            Console.WriteLine($"Logging error to File: {ex}");
        }
    }
}
