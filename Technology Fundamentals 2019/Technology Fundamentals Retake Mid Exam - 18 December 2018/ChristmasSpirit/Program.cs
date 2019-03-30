using System;

namespace ChristmasSpirit
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int cost = 0;
            int holidaySpirit = 0;

            for (int currentDay = 1; currentDay <= days; currentDay++)
            {
                if (currentDay % 11 == 0) //every 11th day increase quantity
                {
                    quantity += 2;
                }
                if (currentDay % 10==0) //every 10th day cat disaster
                {
                    holidaySpirit -= 20;
                    cost += 5 + 3 + 15;
                    
                }

                if (currentDay % 5 == 0) // every five days add cost and additional spirit on 10.
                {
                    cost += 15 * quantity;
                    holidaySpirit += 17;
                    if (currentDay % 3 == 0)
                    {
                        holidaySpirit += 30;
                    }
                }
                if (currentDay % 3 == 0)
                {
                    cost += 8 * quantity;
                    holidaySpirit += 13;
                }
                if (currentDay % 2 == 0)
                {
                    cost += 2 * quantity;
                    holidaySpirit += 5;
                }

            }
            if (days % 10 == 0) // if last day is 10th.
            {
                holidaySpirit -= 30;
            }
            Console.WriteLine($"Total cost: {cost}");
            Console.WriteLine($"Total spirit: {holidaySpirit}");
        }
    }
}
