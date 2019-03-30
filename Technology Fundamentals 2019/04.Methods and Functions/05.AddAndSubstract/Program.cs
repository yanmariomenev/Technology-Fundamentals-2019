using System;

namespace _05.AddAndSubstract
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int lastNum = int.Parse(Console.ReadLine());

           int sumOfTwoNum = sumOfFirstAndSecondNum(num, secondNum);

            Console.WriteLine(Subtrackt(sumOfTwoNum, lastNum));
        }

        private static int Subtrackt(int sumOfTwoNum, int lastNum)
        {
            return sumOfTwoNum - lastNum;
        }

        private static int sumOfFirstAndSecondNum(int num, int secondNum)
        {
           int sumOfFirstAndSecond = num + secondNum;
            return sumOfFirstAndSecond;
        }
    }
}
