using System;
using System.Linq;
namespace _03.ZigZag
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfArrays = int.Parse(Console.ReadLine());
            int[] rightNumber = new int[numberOfArrays];
            int[] leftNumber = new int[numberOfArrays];

            for (int i = 0; i < numberOfArrays; i++)
            {
                int[] currentArray = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                if (i % 2 == 0)
                {
                    rightNumber[i] = currentArray[0];
                    leftNumber[i] = currentArray[1];
                }
                else
                {
                    rightNumber[i] = currentArray[1];
                    leftNumber[i] = currentArray[0];
                }
            }
            Console.WriteLine(string.Join(" ", rightNumber));
            Console.WriteLine(string.Join(" ", leftNumber));
        }
    }
}
