using System;
using System.Linq;
using System.Collections.Generic;
namespace _02.SantasList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> badList = Console.ReadLine().Split("&").ToList();

            string command;
            while ((command = Console.ReadLine()) != "Finished!")
            {
                List<string> kidNames = command.Split().ToList();
                string currentCommand = kidNames[0];
                string names = kidNames[1];
                
                switch (currentCommand)
                {
                    case "Bad":
                        if (!badList.Contains(names))
                        {
                            badList.Insert(0, names);
                        }
                        break;
                    case "Good":
                        if (badList.Contains(names))
                        {
                            badList.Remove(names);
                        }
                        break;
                    case "Rename":
                        string rename = kidNames[2];
                        if (badList.Contains(names))
                        {
                            int index = badList.IndexOf(names);
                            badList.Remove(names);
                            badList.Insert(index, rename);
                        }
                        break;
                    case "Rearrange":
                        if (badList.Contains(names))
                        {
                            badList.Remove(names);
                            badList.Add(names);
                        }
                        break;
                }
                
            }
            Console.WriteLine(string.Join(", ", badList));
        }
    }
}
