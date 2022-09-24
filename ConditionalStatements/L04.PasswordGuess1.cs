using System;

namespace L04.PasswordGuess1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string enteredPass = Console.ReadLine();
            string password = "s3cr3t!P@ssw0rd";

            if (enteredPass == password)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}