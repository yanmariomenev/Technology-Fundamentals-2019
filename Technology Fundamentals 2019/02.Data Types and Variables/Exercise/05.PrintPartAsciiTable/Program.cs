using System;

namespace _05.PrintPartAsciiTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            for (int i = number2; i >= number; number++)
            {
                char symbols = Convert.ToChar(number);
                Console.Write(symbols+ " ");
            }

        }
    }
}
