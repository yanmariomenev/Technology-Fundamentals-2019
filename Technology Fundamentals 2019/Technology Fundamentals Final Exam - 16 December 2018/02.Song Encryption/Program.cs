using System;
using System.Text.RegularExpressions;

namespace _02.Song_Encryption
{
    class Program
    {
        static void Main(string[] args)
        {
            var artistPattern = @"^[A-Z][a-z]+[ |a-z| ']*$";
            Regex artistRegex = new Regex(artistPattern);

            var songPattern = @"^[A-Z]+[ |A-Z]*$";
            var songRegex = new Regex(songPattern);

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                var splittedInput = input.Split(":");
                var artist = splittedInput[0];
                var song = splittedInput[1];
                if (artistRegex.IsMatch(artist) && songRegex.IsMatch(song))
                {
                    var key = artist.Length;
                    Decription(input, key);
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
        }

        private static void Decription(string input, int key)
        {
            string decryptedInput = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                char characterCheck = input[i];
                if (characterCheck == ' ')
                {
                    decryptedInput += characterCheck;
                }
                else if (characterCheck == ':')
                {
                    decryptedInput += '@';
                }
                else if (characterCheck == 39)
                {
                    decryptedInput += (char)39;
                }
                else
                {
                    if (characterCheck >= 65 && characterCheck <= 90)
                    {
                        if (characterCheck + key <= 90)
                        {
                            decryptedInput += (char)(characterCheck + key);
                        }
                        else
                        {
                            int resetChar = characterCheck + key;
                            while (resetChar > 90)
                            {
                                int diffrence = resetChar - 90;
                                resetChar = 64 + diffrence;
                            }
                            decryptedInput += (char)resetChar;
                        }
                    }
                    else if (characterCheck >= 97 && characterCheck <= 122)
                    {
                        if (characterCheck + key <= 122)
                        {
                            decryptedInput += (char)(characterCheck + key);
                        }
                        else
                        {
                            int resetChar = characterCheck + key;
                            while (resetChar > 122)
                            {
                                int diffrence = resetChar - 122;
                                resetChar = 96 + diffrence;
                            }
                            decryptedInput += (char)resetChar;
                        }
                    }
                }
            }
            Console.WriteLine($"Successful encryption: {decryptedInput}");
        }
    }
}
