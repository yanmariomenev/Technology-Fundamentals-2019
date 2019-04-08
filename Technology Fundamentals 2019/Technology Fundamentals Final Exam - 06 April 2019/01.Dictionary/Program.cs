using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var defenisions = new SortedDictionary<string, List<string>>();

            while (true)
            {
                var input = Console.ReadLine().Trim().Split("|").ToArray();
                for (int i = 0; i < input.Length; i++)
                {
                    var splitted = input[i].Split(":").ToList();
                    var word = splitted[0].Trim();
                    if (word == "End")
                    {
                        foreach (var item in defenisions)
                        {
                            Console.WriteLine($"{item.Key}");
                            var sort = item.Value.OrderByDescending(x => x.Length).ToList();
                            for (int j = 0; j < sort.Count; j++)
                            {
                                Console.WriteLine($"-{sort[j]}");
                            }


                        }
                        return;
                    }
                    if (word == "List")
                    {
                        foreach (var item in defenisions)
                        {
                            Console.Write($"{item.Key} ");
                        }
                        return;
                    }
                    if (splitted.Count > 1)
                    {
                        var defenision = splitted[1].Trim();
                        if (!defenisions.ContainsKey(word))
                        {
                            defenisions[word] = new List<string>();
                            defenisions[word].Add(defenision);
                        }
                        else
                        {
                            defenisions[word].Add(defenision);
                        }
                    }

                }

            }
        }
    }
}
