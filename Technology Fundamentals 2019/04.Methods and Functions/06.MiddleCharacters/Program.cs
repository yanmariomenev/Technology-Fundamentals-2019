using System;

namespace _06.MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            printingMiddleChar(input);
        }

        private static void printingMiddleChar(string input)
        {
            if (input.Length % 2== 0)
            {
                Console.WriteLine($"{input[input.Length /2 - 1]}{input[input.Length / 2]}");
            }
            else
            {
                Console.WriteLine($"{input[input.Length / 2]}");
            }
        }
    }
}
