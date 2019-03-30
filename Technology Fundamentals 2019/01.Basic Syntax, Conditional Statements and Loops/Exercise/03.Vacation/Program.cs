using System;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double overAllPrice = 0;
            if (groupType == "Students")
            {
                if (dayOfWeek == "Friday")
                {
                    overAllPrice = groupSize * 8.45;
                }
                else if (dayOfWeek == "Saturday")
                {
                    overAllPrice = groupSize * 9.80;
                }
                else if (dayOfWeek == "Sunday")
                {
                    overAllPrice = groupSize * 10.46;
                }
                if (groupSize >= 30)
                {
                    overAllPrice *= 0.85;
                }
            }
            else if (groupType == "Business")
            {
                if (groupSize >= 100)
                {
                    groupSize -= 10;
                }
                if (dayOfWeek == "Friday")
                {
                    overAllPrice = groupSize * 10.90;
                }
                else if (dayOfWeek == "Saturday")
                {
                    overAllPrice = groupSize * 15.60;
                }
                else if (dayOfWeek == "Sunday")
                {
                    overAllPrice = groupSize * 16;
                }
            }
            else if (groupType == "Regular")
            {
                if (dayOfWeek == "Friday")
                {
                    overAllPrice = groupSize * 15;
                }
                else if (dayOfWeek == "Saturday")
                {
                    overAllPrice = groupSize * 20;
                }
                else if (dayOfWeek == "Sunday")
                {
                    overAllPrice = groupSize * 22.50;
                }
                if (groupSize >= 10 && groupSize <= 20)
                {
                    overAllPrice *= 0.95;
                }
            }
            Console.WriteLine($"Total price: {overAllPrice:F2}");
        }
    }
}
