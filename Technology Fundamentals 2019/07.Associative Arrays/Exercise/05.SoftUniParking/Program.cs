using System;
using System.Linq;
using System.Collections.Generic;
namespace _05.SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int amountOfCars = int.Parse(Console.ReadLine());
            var registeredCars = new Dictionary<string, string>();

            for (int i = 0; i < amountOfCars; i++)
            {
                var registration = Console.ReadLine().Split().ToList();
                string command = registration[0];
                string name = registration[1];
                if (command == "unregister")
                {
                    if (!registeredCars.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                    }
                    else
                    {
                        registeredCars.Remove(name);
                        Console.WriteLine($"{name} unregistered successfully");
                    }
                }

                if (command == "register")
                {
                    string plateNumber = registration[2];
                    if (registeredCars.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {plateNumber}");
                    }
                    else if (!registeredCars.ContainsKey(name))
                    {
                        registeredCars.Add(name, plateNumber);
                        Console.WriteLine($"{name} registered {plateNumber} successfully");
                    }
 
                }
            }
            foreach (var kvp in registeredCars)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }
        }
    }
}
