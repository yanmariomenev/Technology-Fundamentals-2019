using System;

namespace _02.VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine().ToLower();

            CheckVowels(word);
        }

        private static void CheckVowels(string word)
        {
            int totalVawels = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'a' 
                    || word[i] == 'e' 
                    || word[i] == 'i'
                    || word[i] == 'o'
                    || word[i] == 'u')
                {
                    totalVawels++;
                }
            }
            Console.WriteLine(totalVawels);
        }
    }
}
