﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.QuestJournal
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listOfPhrases = Console.ReadLine()
                .Split(", ")
                .ToList();

            string commands;
            while ((commands = Console.ReadLine()) !="Retire!")
            {
                string[] commandLine = commands
                    .Split(" - ")
                    .ToArray();
                string currentCommand = commandLine[0];
                string quest = commandLine[1];

                switch (currentCommand)
                {
                    case "Start":
                        if (!listOfPhrases.Contains(quest))
                        {
                            listOfPhrases.Add(quest);
                        }
                        break;
                    case "Complete":
                        if (listOfPhrases.Contains(quest))
                        {
                            listOfPhrases.Remove(quest);
                        }
                        break;
                    case "Side Quest":
                        List<string> listOfSideQuests = quest.Split(":").ToList();
                        string leftSide = listOfSideQuests[0];
                        string rightSide = listOfSideQuests[1];

                        if (listOfPhrases.Contains(leftSide))
                        {
                            int index = listOfPhrases.IndexOf(leftSide);
                            if (!listOfPhrases.Contains(rightSide))
                            {
                                listOfPhrases.Insert(index + 1, rightSide);
                            }
                        }
                        break;
                    case "Renew":
                        if (listOfPhrases.Contains(quest))
                        {
                            listOfPhrases.Remove(quest);
                            listOfPhrases.Add(quest);
                        }
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine(string.Join(", ", listOfPhrases));
        }
    }
}
