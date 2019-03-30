using System;
using System.Linq;
using System.Collections.Generic;

namespace _02.OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var words = Console.ReadLine().ToLower().Split();

            var duplicate = words.GroupBy(x => x).Where(x => x.Count() % 2 != 0).Select(x => x.Key);
            foreach (var item in duplicate)
            {
                Console.Write(item + " ");
            }
            //var duplicate = new Dictionary<string, int>();
            //foreach (var word in words)
            //{
            //    if (duplicate.ContainsKey(word))
            //    {
            //        duplicate[word]++;
            //    }
            //    else
            //    {
            //        duplicate.Add(word, 1);
            //    }
            //}
            //foreach (var item in duplicate)
            //{
            //    if (item.Value % 2 != 0)
            //    {
            //        Console.Write(item.Key + " ");
            //    }
            //}
        }
    }
}
