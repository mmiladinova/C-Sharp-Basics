using System;

namespace lab._08.BasketballEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int annualTax = int.Parse(Console.ReadLine());

            double sneakers = annualTax - (annualTax * 0.4);
            double trainingSuit = sneakers - (sneakers * 0.2);
            double ball = ((double)1 / 4) * trainingSuit;
            double accessories = ((double)1 / 5) * ball;
            double allCosts = sneakers + trainingSuit + ball + accessories + annualTax;

            Console.WriteLine(allCosts);    
        }
    }
}