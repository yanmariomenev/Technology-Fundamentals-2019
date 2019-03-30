﻿using System;

namespace _06.StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int originalNumber = int.Parse(Console.ReadLine());
            int number = originalNumber;
            int sum = 0;
            while (number > 0)
            {
                int lastDigit = number % 10;
                number /= 10;
                int currentFactorial = 1;

                for (int i = 2; i <= lastDigit; i++)
                {
                    currentFactorial *= i;
                }
                sum += currentFactorial;
            }
            bool isStrong = originalNumber == sum;
            if (isStrong)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
