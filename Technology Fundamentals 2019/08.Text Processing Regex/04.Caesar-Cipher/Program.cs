using System;
using System.Text;

namespace _04.Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();

            StringBuilder sb = new StringBuilder();
            foreach (var item in text)
            {
                var encryptedSymbol = (char)(item + 3);
                sb.Append(encryptedSymbol);
            }
            Console.WriteLine(sb);
        }
    }
}
