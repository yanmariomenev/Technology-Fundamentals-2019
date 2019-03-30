using System;
using System.Linq;
using System.Collections.Generic;
namespace _03.WordSynonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            var dictionaryList = new Dictionary<string, List<string>>();
            for (int i = 0; i < count; i++)
            {
                var words = Console.ReadLine();
                var synonim = Console.ReadLine();
              
                if (!dictionaryList.ContainsKey(words)) 
                    // checks if the word is already existing if not adds it to the dictionary
                {
                    dictionaryList[words] = new List<string>();
                }
                // adds synonim to already existing or new word
                dictionaryList[words].Add(synonim);
                
            }
            foreach (var item in dictionaryList) // prints the word and synonims of it 
            {
                Console.WriteLine($"{item.Key} - {string.Join(", ", item.Value)}");
            }
        }
    }
}
