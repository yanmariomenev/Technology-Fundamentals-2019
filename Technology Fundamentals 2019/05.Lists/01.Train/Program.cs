using System;
using System.Collections.Generic;
using System.Linq;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int capacity = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();
            while (command != "end")
            {
                
                List<string> directions = command.Split().ToList();

                if (directions[0] == "Add")
                {
                    int wagonPassangers = int.Parse(directions[1]);
                    wagons.Add(wagonPassangers);
                }
                else
                {
                    int fittingPassangers = int.Parse(directions[0]);

                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + fittingPassangers <= capacity)
                        {
                            wagons[i] += fittingPassangers;
                            break;
                        }
                    }
                }
                command = Console.ReadLine();
            }
            // string split
            foreach (var item in wagons)
            {
                Console.WriteLine(item);
            }
        }
    }
}
