using System;

namespace _03.Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int amoutOfPeople = int.Parse(Console.ReadLine());
            int peopleLimits = int.Parse(Console.ReadLine());
            Console.WriteLine(Math.Ceiling((double)amoutOfPeople / peopleLimits));
            
            //double amoutOfPeople = double.Parse(Console.ReadLine());
            //double peopleLimits = double.Parse(Console.ReadLine());
            //Console.WriteLine(Math.Ceiling(amoutOfPeople / peopleLimits));
        }
    }
}
