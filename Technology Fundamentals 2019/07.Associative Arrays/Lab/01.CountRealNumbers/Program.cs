using System;
using System.Linq;
using System.Collections.Generic;
namespace _01.CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split().Select(int.Parse);
            var counts = new SortedDictionary<int, int>();
            foreach (var number in list)
            {
                if (counts.ContainsKey(number))
                {
                    counts[number]++;
                }
                else
                {
                    counts[number] = 1;
                    //counts.Add(number, 1);
                }
            }
            foreach (var item in counts)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
