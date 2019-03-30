using System;
using System.Linq;
using System.Collections.Generic;
namespace _02.A_MinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var resaurcesAndValue = new Dictionary<string, int>();
            string resource;
            while ((resource = Console.ReadLine()) != "stop")
            {
                int value = int.Parse(Console.ReadLine());

                if (!resaurcesAndValue.ContainsKey(resource))
                {
                    resaurcesAndValue.Add(resource, 0);
                }

                resaurcesAndValue[resource] += value;


            }
            foreach (var kvp in resaurcesAndValue)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
