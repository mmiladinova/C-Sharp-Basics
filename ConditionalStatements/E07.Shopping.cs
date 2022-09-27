using System;

namespace E07.Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int videoCards = int.Parse(Console.ReadLine());
            int processors = int.Parse(Console.ReadLine());
            int ram = int.Parse(Console.ReadLine());

            double videoCardsPrice = videoCards * 250;
            double processorsPrice = processors * (videoCardsPrice * 0.35);
            double ramPrice = ram * (videoCardsPrice * 0.1);

            double totalPrice = videoCardsPrice + processorsPrice + ramPrice;

            if (videoCards > processors)
            {
                totalPrice -= totalPrice * 0.15;
            }

            double leftMoney = Math.Abs(budget - totalPrice);

            if (budget >= totalPrice)
            {
                Console.WriteLine($"You have {leftMoney:F2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {leftMoney:F2} leva more!");
            }
        }
    }
}