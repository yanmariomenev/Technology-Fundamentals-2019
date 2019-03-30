using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.TestForm
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split().ToList();

            string command;

            while ((command = Console.ReadLine()) != "Stop")
            {
                string[] splitToArray = command.Split().ToArray();
                string input1 = splitToArray[0];

                if (input1 == "Sort")
                {
                    words.Sort();
                    words.Reverse();

                }
                if (input1 == "Delete")
                {
                    string input2 = splitToArray[1];
                    int input2ToInt = int.Parse(splitToArray[1]);
                    if (input2ToInt <= words.Count + 1)
                    {

                        int index = int.Parse(input2);
                        words.RemoveAt(index + 1);
                    }
                    //string input2 = splitToArray[1];
                    //int index = int.Parse(input2);
                    //words.RemoveAt(index + 1);
                }
                if (input1 == "Swap")
                {
                    string input2 = splitToArray[1];
                    string tempArray = splitToArray[2];
                    string tempName = input2;
                    int word1Index = words.IndexOf(input2);
                    int word2Index = words.IndexOf(tempArray);
                    int tempIndex1 = word1Index;
                    int tempIndex2 = word2Index;
                    words.Remove(input2);
                    words.Remove(tempArray);
                    words.Insert(tempIndex1 - 1, tempArray);
                    words.Insert(tempIndex2, tempName);
                    //if (words.Contains(input2) || words.Contains(tempArray))
                    //{
                    //    int word1Index = words.IndexOf(input2);
                    //    int word2Index = words.IndexOf(tempArray);
                    //    int tempIndex1 = word1Index;
                    //    int tempIndex2 = word2Index;
                    //    words.Remove(input2);
                    //    words.Remove(tempArray);
                    //    words.Insert(tempIndex1 - 1, tempArray);
                    //    words.Insert(tempIndex2, tempName);
                    //}
                }
                if (input1 == "Put")
                {
                    string input2 = splitToArray[1];
                    int putIndexWord = int.Parse(splitToArray[2]);
                    words.Insert(putIndexWord - 1, input2);
                    //if (putIndexWord - 1 <= words.Count)
                    //{
                    //    words.Insert(putIndexWord - 1, input2);
                    //}
                }
                if (input1 == "Replace")
                {
                    string input2 = splitToArray[1];
                    string input3 = splitToArray[2];

                    if (words.Contains(input3))
                    {
                        int indexOfinput = words.IndexOf(input3);
                        words.Remove(input3);
                        words.Insert(indexOfinput, input2);
                    }
                }
            }
            Console.WriteLine(string.Join(" ", words));
        }
    }
}
