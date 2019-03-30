using System;
using System.Linq;
using System.Collections.Generic;
namespace _04.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            var orderPrint = new Dictionary<string, List<double>>();

            while (true)
            {
                var orderInput = Console.ReadLine().Split().ToArray();
                if (orderInput[0] == "buy")
                {
                    break;
                }
                string product = orderInput[0];
                double price = double.Parse(orderInput[1]);
                int quantity = int.Parse(orderInput[2]);
                // creates new product(Key) and adds to the list the price and quantity
                if (!orderPrint.ContainsKey(product))
                {
                    orderPrint[product] = new List<double>();
                    orderPrint[product].Add(price);
                }
                // if the product and price exits removes the price to update it
                orderPrint[product].RemoveAt(0); 
                // inserts the new price tag
                orderPrint[product].Insert(0, price);
                // add the quantity to the list
                orderPrint[product].Add(quantity);

            }
            foreach (var item in orderPrint)
            {
                // removes the price at [0] and sums all product quantity
                double quantitySum = item.Value.Skip(1).Sum(); 
                // takes the quantity sum and multiply it by the price
                double sumOfProducs = item.Value[0] * quantitySum;
                
                //Console.WriteLine(string.Join(" ", item.Value));
                // print the output
               Console.WriteLine($"{item.Key} -> {sumOfProducs:F2}");
                //Can add counter to the quantity and price and solve it in a easier way next time...
            }
        }
    }
}
