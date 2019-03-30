using System;

namespace _03.CharacterInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char input = char.Parse(Console.ReadLine());
            char secondInput = char.Parse(Console.ReadLine());

            CharactersInBetweenWords(input, secondInput);
        }

        private static void CharactersInBetweenWords(char start, char end)
        {
            if (end < start)
            {
                char temp = start;
                start = end;
                end = temp;

            }
            for (char i = (char)(start + 1); i < end; i++)
            {
                Console.Write(i + " "); //Convert.ToChar()
            }
        }
    }
}
