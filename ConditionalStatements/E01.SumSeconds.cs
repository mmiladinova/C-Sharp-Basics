using System;

namespace E01.SumSeconds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstTime = int.Parse(Console.ReadLine());
            int secondTime = int.Parse(Console.ReadLine());
            int thirdTime = int.Parse(Console.ReadLine());

            int totalTime = firstTime + secondTime + thirdTime;

            if (totalTime < 60)
            {
                if (totalTime < 10)
                {
                    Console.WriteLine($"0:0{totalTime}");
                }
                else
                {
                    Console.WriteLine($"0:{totalTime}");
                }
               
            }
            else
            {
                int min = totalTime / 60;
                int sec = totalTime % 60;
                if (sec < 10)
                {
                    Console.WriteLine($"{min}:0{sec}");
                }
                else
                {
                    Console.WriteLine($"{min}:{sec}");
                }
            }
        }
    }
}