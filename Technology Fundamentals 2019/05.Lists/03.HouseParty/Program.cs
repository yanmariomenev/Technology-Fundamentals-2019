using System;
using System.Collections.Generic;
using System.Linq;
namespace _03.HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberCommands = int.Parse(Console.ReadLine());
            List<string> guests = new List<string>();

            for (int i = 0; i < numberCommands; i++)
            {
                string[] tokens = Console.ReadLine().Split();

                if (tokens.Length == 3)
                {
                    if (!guests.Contains(tokens[0]))
                    {
                        guests.Add(tokens[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{tokens[0]} is already in the list!");
                    }
                }
                else if (tokens.Length == 4)
                {
                    if (guests.Contains(tokens[0]))
                    {
                        guests.Remove(tokens[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{tokens[0]} is npt on the list!");
                    }
                }
            }
            foreach (var person in guests)
            {
                Console.WriteLine(person);
            }
        }
    }
}
