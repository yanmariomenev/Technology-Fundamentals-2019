using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.Deciphering
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().ToList();
            var addition = Console.ReadLine().Split().ToArray();
            var decripted = new StringBuilder();
            var get = addition[0];
            var set = addition[1];
            var key = -3;
            for (int i = 0; i < text.Count; i++)
            {
                var charackterCheck = text[i];
                if (charackterCheck == 'a' || charackterCheck == 'b'|| charackterCheck == 'c' ) 
                {
                    Console.WriteLine("This is not the book you are looking for.");
                    return;
                }
                if (charackterCheck == '#')
                {
                    decripted.Append(' ');
                }
                else
                {
                    decripted.Append((char)(charackterCheck + key));
                    
                }
                decripted.Replace(get, set);
            }
            Console.WriteLine(decripted);
            
        }
    }
}
