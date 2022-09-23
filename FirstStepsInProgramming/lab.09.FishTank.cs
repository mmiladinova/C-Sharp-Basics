using System;

namespace lab._09.FishTank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double aquariumVolume = length * width * height;
            double waterVolume = aquariumVolume - (aquariumVolume * (percent / 100));
            double waterInLiters = waterVolume * 0.001;
            Console.WriteLine(waterInLiters);
        }
    }
}