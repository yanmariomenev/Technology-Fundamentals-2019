using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.CardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> playerDeck1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> playerDeck2 = Console.ReadLine().Split().Select(int.Parse).ToList();
            int deckSum = 0;
            int deckSum2 = 0;
            int counter = 0;
            // CHECK THE REMOVE PROCCESS FIND THE RIGHT WAY TO DO IT  !!!
            for (int i = 0; i < playerDeck1.Count; i++)
            {
                for (int j = 0 + counter; j < playerDeck2.Count; j++)
                {
                    if (playerDeck1[i] == playerDeck2[j])
                    {
                        playerDeck1.RemoveAt(i);
                        playerDeck2.RemoveAt(j);
                        counter += 1;
                        break;
                    }
                    if (playerDeck1[i] > playerDeck2[j])
                    {
                        deckSum += playerDeck1[i] + playerDeck2[j];
                        playerDeck1.Add(playerDeck2[j]);
                        playerDeck2.Remove(j);
                        counter += 1;
                        break;
                    }
                    else if (playerDeck1[i] < playerDeck2[j])
                    {
                        counter += 1;
                        deckSum2 +=playerDeck1[i] + playerDeck2[j];
                        playerDeck2.Add(playerDeck1[i]);
                        playerDeck1.Remove(i);
                        break;
                    }
                    
                }
                //playerDeck1.RemoveAt(0);
                //playerDeck2.RemoveAt(0);
            }
            int deck1 = playerDeck1.Sum();
            int deck2 = playerDeck2.Sum();
            Console.WriteLine(deck1 + "-" + deck2);
            //if (deckSum > deckSum2)
            //{
            //    Console.WriteLine($"First player wins! Sum: {deckSum}");
            //}
            //else if (deckSum2 > deckSum)
            //{
            //    Console.WriteLine($"Second player wins! Sum: {deckSum2}");
            //}
            //Console.WriteLine(deckSum);
            //Console.WriteLine(deckSum2);
            
        }
    }
}
