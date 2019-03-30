using System;
using System.Linq;
namespace _06.EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbersArray = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string endResult = "no";
            for (int i = 0; i < numbersArray.Length ; i++)
            {
                int rightSum = 0;
                int leftSum = 0;

                for (int k = i - 1; k >= 0; k--)
                {
                    leftSum += numbersArray[k];
                }
                for (int j = i + 1; j < numbersArray.Length; j++)
                {
                    rightSum += numbersArray[j];

                }
                if (rightSum == leftSum)
                {
                    endResult = Convert.ToString(i);
                    break;
                }
            }
            Console.WriteLine(endResult);

        }
    }
}
