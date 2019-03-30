using System;
using System.Linq;
using System.Collections.Generic;
namespace _01.CountCharInString
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Where(x => x != ' ').ToArray();

            var charCount = new Dictionary<char, int>();

            foreach (var item in input)
            {
                if (!charCount.ContainsKey(item))
                {
                    charCount[item] = 0;
                }
                charCount[item]++;
            }
            foreach (var count in charCount)
            {
                Console.WriteLine($"{count.Key} -> {count.Value}");
            }
        }
    }
}
