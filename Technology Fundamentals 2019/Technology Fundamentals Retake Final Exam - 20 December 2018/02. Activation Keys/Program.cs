using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _02._Activation_Keys
{
    class Program
    {
        static void Main(string[] args)
        {
            var keys = Console.ReadLine().Split('&').ToArray();
            var validKeys = new List<string>();
            var pattern = @"^[a-zA-Z0-9]+$";
            
            for (int i = 0; i < keys.Length; i++)
            {
                if (keys[i].Length == 25 || keys[i].Length == 16)
                {
                    var match = Regex.Match(keys[i], pattern);
                    if (match.Success)
                    {
                        validKeys.Add(keys[i]);
                    }
                }
            }
            var validFixedKeys = new StringBuilder();
            for (int i = 0; i < validKeys.Count; i++)
            {
                var val = validKeys[i].Length;
               
                var character = validKeys[i];
                for (int j = 0; j < character.Length; j++)
                {
                    
                    if (char.IsLetter(character[j]))
                    {
                        validFixedKeys.Append(char.ToUpper(character[j]));
                    }
                    else
                    {
                        var digit = 9 - int.Parse(character[j].ToString());
                        validFixedKeys.Append(digit);
                    }
                    if (val == 16)
                    {
                        if (j == 3 || j == 7 || j == 11)
                        {
                            validFixedKeys.Append("-");
                        }
                    }
                    else
                    {
                        if (j == 4 || j == 9 || j == 14 ||j == 19)
                        {
                            validFixedKeys.Append("-");
                        }
                    }
                }
                validFixedKeys.Append(", ");
            }
            validFixedKeys = validFixedKeys.Remove(validFixedKeys.Length - 2, 1);
            Console.WriteLine(validFixedKeys);
  
        }
    }
}
