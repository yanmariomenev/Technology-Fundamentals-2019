using System;

namespace _02.SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumDig = 0;

            while (n != 0)
            {
                sumDig += n % 10;
                n = n / 10;
            }
            Console.WriteLine(sumDig);           
        }
    }
}
