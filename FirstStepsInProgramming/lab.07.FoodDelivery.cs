using System;

namespace lab._07.FoodDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chickenMenus = int.Parse(Console.ReadLine());
            int fishMenus = int.Parse(Console.ReadLine());
            int vegetarianMenus = int.Parse(Console.ReadLine());


            double chickenMenuAmount = chickenMenus * 10.35;
            double fishMenusAmount = fishMenus * 12.40;
            double vegetarianMenusamount = vegetarianMenus * 8.15;
            double allMenusAmount = chickenMenuAmount + fishMenusAmount + vegetarianMenusamount;
            double dessert = allMenusAmount * 0.2;
            double delivery = 2.5;
            double totalAmount = allMenusAmount + dessert + delivery;
            Console.WriteLine(totalAmount);
        }
    }
}