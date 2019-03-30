using System;

namespace _01.IntegerOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            int n4 = int.Parse(Console.ReadLine());

            int addNum = n1 + n2;
            int devideNum = addNum / n3;
            Console.WriteLine(devideNum * n4);
        }
    }
}
