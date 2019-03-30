using System;

namespace _05.Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            string password = "";
            for (int i = userName.Length - 1; i >= 0; i--)
            {
                password += userName[i];
            }
            string currentPassword = Console.ReadLine();
            int invalidPassword = 0;
            while (currentPassword != password)
            {
                invalidPassword += 1;
                if (invalidPassword == 4)
                {
                    Console.WriteLine($"User {userName} blocked!");
                    break;
                }
                Console.WriteLine("Incorrect password. Try again.");
                currentPassword = Console.ReadLine();   
            }
            if (invalidPassword < 4)
            {
                Console.WriteLine($"User {userName} logged in.");
            }
            
        }
    }
}
