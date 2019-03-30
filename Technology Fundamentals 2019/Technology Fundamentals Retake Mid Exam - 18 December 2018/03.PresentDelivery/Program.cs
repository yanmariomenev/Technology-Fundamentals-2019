using System;
using System.Linq;
using System.Collections.Generic;
namespace _03.PresentDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> homes = Console.ReadLine().Split("@").Select(int.Parse).ToList();
            string command;
            int santaIndex = 0;
            while ((command = Console.ReadLine()) !="Merry Xmas!")
            {
                string[] santaCommand = command.Split().ToArray();
                string jumpCommand = santaCommand[0];
                int jumpSize = int.Parse(santaCommand[1]);

                if (santaIndex + jumpSize >= homes.Count)
                {
                    santaIndex = (santaIndex + jumpSize) % homes.Count;
                    // santa starts from 0.
                }
                else
                {
                    santaIndex += jumpSize;
                    // santa lands on the index house
                }
                if (homes[santaIndex] == 0)
                {
                    Console.WriteLine($"House {santaIndex} will have a Merry Christmas.");
                    // checks if the index reached 0.
                }
                else
                {
                    homes[santaIndex] -= 2;
                    // if not adds 2 presents removes  2 people from the list till reaches 0
                }
    

            }

            int faildHomes = homes.Where(x => x != 0).Count(); 
            // checks every index if they are above 0/ faild.

            Console.WriteLine($"Santa's last position was {santaIndex}.");

            if (faildHomes > 0)
            {
                Console.WriteLine($"Santa has failed {faildHomes} houses.");
            }
            else
            {
                Console.WriteLine("Mission was successful.");
            }
        }
    }
}
