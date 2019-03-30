using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace _05.Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = Console.ReadLine().ToList();
            var second = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < first.Count; i++)
            {
               
               int num = int.Parse(first[i].ToString());
                double end = second * num;
                
                sb.Append(end);
            }
            Console.WriteLine(sb);
        }
    }
}
