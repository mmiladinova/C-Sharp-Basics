using System;

namespace E04.ToyShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double excursionPrice = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int speakingDolls = int.Parse(Console.ReadLine());
            int teddyBears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            double puzzlePrice = 2.6;
            double speakingDollPrice = 3.0;
            double teddyBearPrice = 4.10;
            double minionPrice = 8.20;
            double truckPrice = 2.0;

            double toysPrice = puzzles * puzzlePrice + speakingDolls * speakingDollPrice + 
                teddyBears * teddyBearPrice + minions * minionPrice + trucks * truckPrice;
            int toysCount = puzzles + speakingDolls + teddyBears + minions + trucks;

            if (toysCount >= 50)
            {
                toysPrice = toysPrice - toysPrice * 0.25;
            }

            double rent = toysPrice * 0.1;
            double earnedMoney = toysPrice - rent;

            double leftMoney =Math.Round(Math.Abs(earnedMoney - excursionPrice), 2);

            if (excursionPrice <= earnedMoney)
            {
                
                Console.WriteLine($"Yes! {leftMoney:F2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {leftMoney:F2} lv needed.");
            }
        }
    }
}