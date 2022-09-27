using System;

namespace Е05.GodzillaVs.Kong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double filmBudget = double.Parse(Console.ReadLine());
            int extras = int.Parse(Console.ReadLine());
            double clothesPricePerPerson = double.Parse(Console.ReadLine());

            double decorPrice = filmBudget * 0.1;
            double clothsPrice = extras * clothesPricePerPerson;

            if (extras > 150)
            {
                clothsPrice -= clothsPrice * 0.1;
            }

            double expences = clothsPrice + decorPrice;

            if (filmBudget >= expences)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {(filmBudget - expences):F2} leva left.");
            }
            else
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {(expences - filmBudget):F2} leva more.");
            }
        }
    }
}