using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Concert
{
    class Program
    {
        static void Main(string[] args)
        {
            var bandPlayTime = new Dictionary<string, int>();
            var bandLineUp = new Dictionary<string, List<string>>();
            var startBand = string.Empty;
            while (true)
            {
                var command = Console.ReadLine().Split("; ").ToList();

                var addOrPlay = command[0];

                if (addOrPlay == "start of concert")
                {
                    startBand = Console.ReadLine();
                    break;
                }
                var bandName = command[1];
                var memberList = command[2].Split(", ");
                if (addOrPlay == "Play")
                {
                    var playTime = int.Parse(command[2]);
                    if (!bandPlayTime.ContainsKey(bandName))
                    {
                        bandPlayTime.Add(bandName, playTime);
                    }
                    else
                    {
                        bandPlayTime[bandName] += playTime;
                    }
                }
                else
                {
                    if (!bandLineUp.ContainsKey(bandName))
                    {
                        bandLineUp[bandName] = new List<string>();
                        bandLineUp[bandName].AddRange(memberList);
                        //for (int i = 2; i < command.Count; i++)
                        //{
                        //    bandLineUp[bandName].Add(command[i]);
                        //}
                    }
                    else
                    {
                        for (int j = 0; j < memberList.Length; j++)
                        {
                            string member = memberList[j];
                            if (!bandLineUp[bandName].Contains(member))
                            {
                                bandLineUp[bandName].Add(member);
                            }
                        }
                    }
                }
            }
            var totalTime = bandPlayTime.Sum(x => x.Value);
            var sortBand = bandPlayTime.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToList();
            Console.WriteLine($"Total time: {totalTime}");
            foreach (var kvp in sortBand)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
            Console.WriteLine(startBand);
            var bandMember = bandLineUp[startBand].ToList();

            foreach (var member in bandMember)
            {
                Console.WriteLine($"=> {member}");
            }

        }
    }
}
