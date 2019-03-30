using System;

namespace _01.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfWagons = int.Parse(Console.ReadLine());
            int[] passangers = new int[numberOfWagons];
            int allPassangers = 0;
            for (int i = 0; i < passangers.Length; i++)
            {
                passangers[i] = int.Parse(Console.ReadLine());
                allPassangers += passangers[i];

            }
            Console.WriteLine(string.Join(" ", passangers));
            Console.WriteLine(allPassangers);

            //string name = Console.ReadLine();
            //string[] splitNames = name.Split(" ").ToArray(); split names by space or other symbol
            //string[] splitNames = name.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToArray(); remove empty spaces from input

            //int[] numbers = Console.ReadLine() 
            //    .Split()
            //    .Select(int.Parse)
            //    .ToArray();
        }
    }
}
