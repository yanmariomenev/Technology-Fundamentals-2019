using System;
using System.Collections.Generic;
using System.Linq;
namespace _04.IronGirder
{
    class TimeAndPassangers
    {
        public int Time { get; set; }
        public int Passangers { get; set; }
    }
    class Program
    {

        static void Main(string[] args)
        {
            var townLogs = new Dictionary<string, TimeAndPassangers>();

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "Slide rule")
                {
                    break;
                }
                var splitInput = input.Split(new string[] { ":", "->" }, StringSplitOptions.RemoveEmptyEntries);

                var town = splitInput[0];
                var time = splitInput[1];
                var passangers = splitInput[2];
                if (time == "ambush" && !townLogs.ContainsKey(town))
                {
                    townLogs[town] = new TimeAndPassangers();
                    townLogs[town].Time = 0;
                    townLogs[town].Passangers = 0;
                }
                else if (time == "ambush" && townLogs.ContainsKey(town))
                {
                    townLogs[town].Time = 0;
                    townLogs[town].Passangers -= int.Parse(passangers);
                }
                else
                {
                    if (!townLogs.ContainsKey(town))
                    {
                        townLogs[town] = new TimeAndPassangers();
                    }
                    if (townLogs[town].Time > int.Parse(time) || townLogs[town].Time == 0)
                    {
                        townLogs[town].Time = int.Parse(time);
                    }
                   
                    townLogs[town].Passangers += int.Parse(passangers);
                }
                
            }
            foreach (var item in townLogs.Where(x => x.Value.Time > 0).Where(x => x.Value.Passangers >= 0).OrderBy(x => x.Value.Time).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} -> Time: {item.Value.Time} -> Passengers: {item.Value.Passangers}");
            }
        }
    }
}
