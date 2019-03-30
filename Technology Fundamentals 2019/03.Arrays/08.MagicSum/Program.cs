using System;
using System.Linq;
namespace _08.MagicSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] magicSum = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int targetNumber = int.Parse(Console.ReadLine());
            for (int i = 0; i < magicSum.Length; i++)
            {
                for (int j = i + 1; j < magicSum.Length; j++)
                {
                    if (magicSum[i] + magicSum[j] == targetNumber)
                    {
                        Console.WriteLine((magicSum[i])+ " " + magicSum[j]);
                    }
                }
            }
        }
    }
}
