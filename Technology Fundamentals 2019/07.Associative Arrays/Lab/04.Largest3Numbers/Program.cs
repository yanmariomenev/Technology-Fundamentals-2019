using System;
using System.Linq;
using System.Collections.Generic;
namespace _04.Largest3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).OrderByDescending(x => x).Take(3);
            foreach (var item in numbers)
            {
                Console.Write(item + " ");
            }
        }
    }
}
