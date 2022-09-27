using System;

namespace E03.TimePlus15Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int mins = hours * 60 + minutes;
            int minsPlus15 = mins + 15;

            int resultHour = minsPlus15 / 60;
            int resultMinutes = minsPlus15 % 60;

            if (resultHour == 24)
            {
                resultHour = 0;
            }
            
            if (resultMinutes < 10)
            {
                Console.WriteLine($"{resultHour}:0{resultMinutes}");
            }
            else
            {
                Console.WriteLine($"{resultHour}:{resultMinutes}");
            }
        }
    }
}