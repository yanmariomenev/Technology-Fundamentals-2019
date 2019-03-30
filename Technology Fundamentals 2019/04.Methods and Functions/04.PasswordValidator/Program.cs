using System;

namespace _04.PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPassword = Console.ReadLine();

            bool isBetweenCharacters = CharacterPasswordChecker(inputPassword);
            bool isOnlyLettersAndDigis = CharsChecker(inputPassword);
            bool haveAtLeastTwoDigits = DigitChecker(inputPassword);

            if (!isBetweenCharacters)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!isOnlyLettersAndDigis)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!haveAtLeastTwoDigits)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if (isBetweenCharacters 
                && isOnlyLettersAndDigis
                && haveAtLeastTwoDigits)
            {
                Console.WriteLine("Password is valid");
            }
        }

        private static bool DigitChecker(string inputPassword)
        {
            int counter = 0;
            for (int i = 0; i < inputPassword.Length; i++)
            {
                if (char.IsDigit(inputPassword[i]))
                {
                    counter++;
                }
            }
            if (counter >= 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool CharsChecker(string inputPassword)
        {
            for (int i = 0; i < inputPassword.Length; i++)
            {
                if (!char.IsLetterOrDigit(inputPassword[i]))
                {
                    return false;
                } 
            }
            return true;
        }

        private static bool CharacterPasswordChecker(string inputPassword)
        {
            if (inputPassword.Length >= 6 && inputPassword.Length <= 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
