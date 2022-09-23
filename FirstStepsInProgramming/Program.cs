using System;

namespace _07.ProjectCreations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int projectCount = int.Parse(Console.ReadLine());

            int totalHours = projectCount * 3;
            Console.WriteLine($"The architect {name} will need {totalHours} hours to complete {projectCount} project/s.");
        }
    }
}