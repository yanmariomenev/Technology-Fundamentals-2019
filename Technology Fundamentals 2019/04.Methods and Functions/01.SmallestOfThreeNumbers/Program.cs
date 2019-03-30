using System;

namespace _01.SmallestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            SmallestOfThreeNumbers(num, secondNum, thirdNum);
            
        }
        private static void SmallestOfThreeNumbers(int num, int sNum, int tNum)
        {
            int result = 0;
            if (num < sNum && num < tNum)
            {
                result = num;
            }
            else if (sNum < tNum)
            {
                result = sNum;
            }
            else
            {
                result = tNum;
            }
            Console.WriteLine(result);
            // Can use return method
        }
    }
}
