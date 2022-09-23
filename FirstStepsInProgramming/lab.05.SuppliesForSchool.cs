using System;

namespace lab._05.SuppliesForSchool
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int packagesPencils = int.Parse(Console.ReadLine());
            int packagesMarkers = int.Parse(Console.ReadLine());
            int blackboardCleaner = int.Parse(Console.ReadLine());  
            int discountPercent = int.Parse(Console.ReadLine());   

            double pencilsAmount = packagesPencils * 5.80;
            double markersAmount = packagesMarkers * 7.20;
            double cleanerAmount = blackboardCleaner * 1.20;
            double amount = pencilsAmount + markersAmount + cleanerAmount;

            double discount = amount * ((double)discountPercent / 100);
            double totalAmount = amount - discount;
            Console.WriteLine(totalAmount);





        }
    }
}