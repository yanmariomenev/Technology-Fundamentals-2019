using System;
using System.Linq;
using System.Collections.Generic;
namespace _08.CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            var companyUsers = new SortedDictionary<string, List<string>>();

            while (true)
            {
                var input = Console.ReadLine().Split(" -> ");
                var companyName = input[0];
                if (companyName == "End")
                {
                    break;
                }
                var userId = input[1];
                if (!companyUsers.ContainsKey(companyName))
                {
                    companyUsers[companyName] = new List<string>(); 
                }
                companyUsers[companyName].Add(userId);
            }
            foreach (var kvp in companyUsers)
            {
                Console.WriteLine($"{kvp.Key}");
                foreach (var ids in kvp.Value.Distinct()) //Distinct = doesn't print duplicates
                {
                    Console.WriteLine($"-- {ids}");
                }
            }
        }
    }
}
