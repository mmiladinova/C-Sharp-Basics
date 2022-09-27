using System;

namespace E06.WorldSwimmingRecord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double worldRecord = double.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            double secsPerMeter = double.Parse(Console.ReadLine());

            double secForSwimming = length * secsPerMeter;
            double delay = Math.Floor(length / 15) * 12.5;
            double totalTime = secForSwimming + delay;
            double diff = totalTime - worldRecord;
            
            if (worldRecord > totalTime)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:F2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {diff:F2} seconds slower.");
            }
        }
    }
}