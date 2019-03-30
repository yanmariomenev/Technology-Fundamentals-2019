using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01.ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(", ").ToArray();
            

            for (int i = 0; i < words.Length; i++)
            {
                var word = words[i];
                bool isValid = false;

                if (word.Length >= 3 && word.Length <= 16)
                {
                    for (int j = 0; j < word.Length; j++)
                    {
                        char currentCharacter = word[j];
                        if (char.IsLetterOrDigit(currentCharacter) 
                            || currentCharacter == '-' 
                            || currentCharacter == '_')
                        {
                            isValid = true;

                        }
                        else
                        {
                            isValid = false;
                            break;
                        }
                    } 
                }
                if (isValid)
                {
                    Console.WriteLine(word);
                }
            }
        }
    }
}
