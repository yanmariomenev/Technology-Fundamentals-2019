using System;
using System.Linq;
using System.Collections.Generic;
namespace _07.StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentsAndScores = new Dictionary<string, List<double>>();
            var countToAdd = int.Parse(Console.ReadLine());

            for (int i = 0; i < countToAdd; i++)
            {
                var name = Console.ReadLine();
                var score = double.Parse(Console.ReadLine());

                if (!studentsAndScores.ContainsKey(name))
                {
                    studentsAndScores[name] = new List<double>();
                }
                studentsAndScores[name].Add(score);
            }
            var studentsWithAverageGrade = new Dictionary<string, double>();
            foreach (var kvp in studentsAndScores)
            {
                var checkScore = kvp.Value.Average();
                studentsWithAverageGrade.Add(kvp.Key, checkScore);
            }
            var results = studentsWithAverageGrade
                .Where(x => x.Value >= 4.50)
                .OrderByDescending(x => x.Value).ToList();
            foreach (var kvp in results)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value:F2}");
            }
        }
    }
}
