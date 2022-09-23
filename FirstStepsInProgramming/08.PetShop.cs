using System;
namespace _08.PetShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dogsPack = int.Parse(Console.ReadLine());
            int catsPack = int.Parse(Console.ReadLine());
            
            double totalAmount = (catsPack * 4) + (dogsPack * 2.50);

            Console.WriteLine($"{totalAmount} lv.");


        }
    }
}
