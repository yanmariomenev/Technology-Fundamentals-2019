using System;

namespace _03.Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            var filePath = Console.ReadLine();
            int fileIndex = filePath.LastIndexOf('\\')+1;
            var file = filePath.Substring(fileIndex).Split(".");
            Console.WriteLine($"File name: {file[0]}");
            Console.WriteLine($"File extension: {file[1]}");

        }
    }
}
