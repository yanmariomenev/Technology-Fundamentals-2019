using System;
using System.Linq;

namespace _02.Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            var tokens = Console.ReadLine().Split();
            var firstWord = tokens[0];
            var secondWord = tokens[1];

            var longerWord = string.Empty;
            var shorterWord = string.Empty;
            var Totalsum = 0;

            if (firstWord.Length >= secondWord.Length)
            {
                longerWord = firstWord;
                shorterWord = secondWord;
            }
            else
            {
                longerWord = secondWord;
                shorterWord = firstWord;
            }
            for (int i = 0; i < shorterWord.Length; i++)
            {
                Totalsum += longerWord[i] * shorterWord[i];
            }
            for (int j = shorterWord.Length; j < longerWord.Length; j++)
            {
                Totalsum += longerWord[j];
            }
            Console.WriteLine(Totalsum);
        }
    }
}
