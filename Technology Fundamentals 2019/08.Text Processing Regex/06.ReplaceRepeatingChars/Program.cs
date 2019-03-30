using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
namespace _06.ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var output = string.Empty;
            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] != input[i + 1])
                {
                    output += input[i];
                }
            }
            output += input[input.Length - 1];
            Console.WriteLine(output);
            
        }
    }
}
