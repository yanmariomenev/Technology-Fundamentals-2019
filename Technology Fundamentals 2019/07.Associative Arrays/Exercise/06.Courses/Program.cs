using System;
using System.Linq;
using System.Collections.Generic;
namespace _06.Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            var lessonsAndstudents = new Dictionary<string, List<string>>();
            bool endProgram = true;
            while (endProgram)
            {
                var commands = Console.ReadLine().Split(" : ");
                var studyProgram = commands[0];
                if (studyProgram == "end")
                {
                    endProgram = false;
                    break;
                }
                var studentName = commands[1];
                if (!lessonsAndstudents.ContainsKey(studyProgram))
                {

                    lessonsAndstudents[studyProgram] = new List<string>();
                    
                }
                lessonsAndstudents[studyProgram].Add(studentName);
            }
            var sortDict = lessonsAndstudents.OrderByDescending(x => x.Value.Count).ToList();
            foreach (var kvp in sortDict)
            {
                Console.WriteLine($" {kvp.Key}: {kvp.Value.Count}");
                var students = kvp.Value.OrderBy(x => x).ToList();
                foreach (var item in students)
                {
                    Console.WriteLine($"-- {item}");
                }
            }
        }
    }
}
