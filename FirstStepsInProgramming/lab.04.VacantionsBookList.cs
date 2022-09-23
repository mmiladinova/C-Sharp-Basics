using System;

namespace lab._06.VacantionsBookList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bookPages = int.Parse(Console.ReadLine());
            int pagesPerHour = int.Parse(Console.ReadLine());
            int daysForReading = int.Parse(Console.ReadLine());

            int hoursPerBook = bookPages / pagesPerHour;
            int hoursPerDay = hoursPerBook / daysForReading;

            Console.WriteLine(hoursPerDay);

        }
    }
}