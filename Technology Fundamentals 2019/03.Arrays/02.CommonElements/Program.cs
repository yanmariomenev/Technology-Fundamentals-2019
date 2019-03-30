using System;
using System.Linq;

namespace _02.CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] firstCompere = input.Split(" ").ToArray();
            string secondInput = Console.ReadLine();
            string[] secondCompere = secondInput.Split(" ").ToArray();
            var intersect = firstCompere.Intersect(secondCompere);
            foreach (var duplicate in intersect)
            {
                Console.Write(duplicate + " ");
            }
        }
    }
}
