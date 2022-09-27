using System;

namespace E08.LunchBreak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filmName = Console.ReadLine();
            int filmLength = int.Parse(Console.ReadLine());
            int breakLength = int.Parse(Console.ReadLine());

            double timeForLunch = ((double)1 / 8) * breakLength;
            double timeForRest = ((double)1 / 4) * breakLength;
            double timeForMovie = breakLength - (timeForLunch + timeForRest);
            double leftTime =Math.Ceiling(Math.Abs(timeForMovie - filmLength));

            if (timeForMovie >= filmLength)
            {
                Console.WriteLine($"You have enough time to watch {filmName} and left with {leftTime} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {filmName}, you need {leftTime} more minutes.");
            }
        }
    }
}