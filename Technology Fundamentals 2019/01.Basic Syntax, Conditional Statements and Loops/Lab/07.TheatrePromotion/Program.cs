﻿using System;

namespace _07.TheatrePromotion
{
    class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine().ToLower();
            int age = int.Parse(Console.ReadLine());
            int price = 0;

            if (age < 0 || age > 122)
            {
                Console.WriteLine("Error!");
                return;
            }
            if (day == "weekday")
            {
                if (age >= 0 && age <= 18 || age > 64 && age <= 122)
                {
                    price = 12;
                }
                else if (age > 18 && age <= 64)
                {
                    price = 18;
                }
            }
            if (day == "weekend")
            {
                if (age >= 0 && age <= 18 || age > 64 && age <= 122)
                {
                    price = 15;
                }
                else if (age > 18 && age <= 64)
                {
                    price = 20;
                }
            }
            if (day == "holiday")
            {
                if (age >= 0 && age <= 18 )
                {
                    price = 5;
                }
                else if (age > 64 && age <= 122)
                {
                    price = 10;
                }
                else if (age > 18 && age <= 64)
                {
                    price = 12;
                }
            }
            Console.WriteLine($"{price}$");
        }
    }
}
