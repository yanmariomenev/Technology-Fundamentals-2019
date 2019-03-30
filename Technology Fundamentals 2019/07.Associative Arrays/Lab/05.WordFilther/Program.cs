using System;
using System.Linq;
using System.Collections.Generic;
namespace _05.WordFilther
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split().Where(x => x.Length % 2 == 0);
            foreach (var item in words)
            {
                Console.WriteLine(item);
            }
        }
    }
}
