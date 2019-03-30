using System;
using System.Linq;
namespace _09.PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            PalidromeChecker(input);
            
        }

        private static void PalidromeChecker(string input)
        {
            string reversed = string.Empty;

            while (input != "END")
            {
                input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }

                for (int i = input.Length - 1; i >= 0; i--)
                {
                    reversed += input[i];
                }
                if (reversed != input)
                {
                    Console.WriteLine("false");
                }
                else if (reversed == input)
                {
                    Console.WriteLine("true");
                }
                //Before: reversed is not empty
                reversed = string.Empty;
                //After: reversed is empty
            }
        }
    }
}
