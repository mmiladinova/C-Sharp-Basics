using System;

namespace lab._06.Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {     
            int nylon = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int thinner = int.Parse(Console.ReadLine());
            int workinHours = int.Parse(Console.ReadLine());
            
            double nylonAmount = (nylon + 2) * 1.50;
            double paintAmount = (paint + (paint * 0.1)) * 14.50;
            double thinnerAmount = thinner * 5;
            double bagsAmount = 0.4;

            double materialsAmount = nylonAmount + paintAmount + thinnerAmount + bagsAmount;
            double workersSalary = materialsAmount * 0.3;
            double totalAmount = materialsAmount + (workersSalary * workinHours);

            Console.WriteLine(totalAmount);
        }
    }
}