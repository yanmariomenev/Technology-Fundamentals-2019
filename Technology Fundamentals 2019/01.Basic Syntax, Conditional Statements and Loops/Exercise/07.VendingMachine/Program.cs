using System;

namespace _07.VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double balance = 0;
            while (input != "Start")
            {
                double insertCoin = double.Parse(input);
                if (insertCoin == 0.1 ||
                    insertCoin == 0.2 ||
                    insertCoin == 0.5 ||
                    insertCoin == 1 ||
                    insertCoin == 2)
                {
                    balance += insertCoin;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {input}");
                }
                input = Console.ReadLine();
            }
            input = Console.ReadLine();
            double productPrice = 0;
            while (input != "End")
            {
                switch (input)
                {
                    case "Nuts": productPrice = 2.0;
                        break;
                    case "Water": productPrice = 0.7;
                        break;
                    case "Crisps": productPrice = 1.5;
                        break;
                    case "Coke": productPrice = 1.0;
                        break;
                    case "Soda": productPrice = 0.8;
                        break;

                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }
                if (balance >= productPrice && productPrice > 0)
                {
                    string productToLower = input.ToLower();
                    Console.WriteLine($"Purchased {productToLower}");
                    balance -= productPrice;
                }
                else if (productPrice > 0)
                {
                    Console.WriteLine("Sorry, not enough money");
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"Change: {balance:F2}");
        }
    }
}
