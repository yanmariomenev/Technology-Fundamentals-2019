using System;
using System.Linq;
using System.Collections.Generic;
namespace _07.MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numberSequence = Console.ReadLine()
                   .Split()
                   .Select(int.Parse)
                   .ToArray();

            int longestSeqLength = 1;
            int longestSeqStart = 0;
            int currentSeqLength = 1;
            int currentSeqStart = 0;
            for (int i = 1; i < numberSequence.Length; i++)
            {
                if (numberSequence[i] == numberSequence[i - 1])
                {
                    currentSeqLength++;
                    if (currentSeqLength > longestSeqLength)
                    {
                        longestSeqLength = currentSeqLength;
                        longestSeqStart = currentSeqStart;
                    }
                }
                else
                {
                    currentSeqLength = 1;
                    currentSeqStart = i;
                }
            }
            for (int i = longestSeqStart; i < longestSeqStart + longestSeqLength; i++)
            {
                Console.Write(numberSequence[i] + " ");
            }
            //int[] longestSequence = new int[0];

            //for (int i = 0; i < numberSequence.Length; i++)
            //{
            //    string[] elements = new string[] { };
            //    var currentSequence = new int[0];
            //    for (int j = i; j < numberSequence.Length; j++)
            //    {
            //        if (numberSequence[i] == numberSequence[j])
            //        {

            //        }
            //        else
            //        {
            //            break;
            //        }
            //    }
            //    if (longestSequence.Length < currentSequence.Length)
            //    {
            //        longestSequence = currentSequence;
            //    }
            //}
            //Console.WriteLine(string.Join(" ", longestSequence));
        }
    }
}
