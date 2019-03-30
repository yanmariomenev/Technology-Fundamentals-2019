using System;
using System.Linq;
using System.Collections.Generic;
namespace _03.LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            //var listOfRes = Console.ReadLine().Split().Reverse();
            var legMats = new Dictionary<string, int>();
            legMats["fragments"] = 0;
            legMats["shards"] = 0;
            legMats["motes"] = 0;
            var junkElements = new Dictionary<string, int>();

            while (true)
            {
                bool matsReach = false;
                var tokens = Console.ReadLine().ToLower().Split();
                for (int i = 0; i < tokens.Length; i += 2)
                {
                    string type = tokens[i + 1];
                    int quantity = int.Parse(tokens[i]);

                    if (legMats.ContainsKey(type))
                    {
                        legMats[type] += quantity;
                        if (legMats[type] >= 250)
                        {
                            matsReach = true;
                            if (type == "shards")
                            {
                                Console.WriteLine("Shadowmourne obtained!");
                                
                            }
                            else if (type == "fragments")
                            {
                                Console.WriteLine("Valanyr obtained!");
                            }
                            else
                            {
                                Console.WriteLine("Dragonwrath obtained!");
                            }
                            legMats[type] -= 250;
                            break;
                        }
                    }
                    else
                    {
                        if (junkElements.ContainsKey(type))
                        {
                            junkElements[type] += quantity;

                        }
                        else
                        {
                            junkElements[type] = quantity;
                        }
                    }
                }
                if (matsReach)
                {
                    break;
                }
            }
            foreach (var kvp in legMats.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
            foreach (var kvp in junkElements.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
    }
}
