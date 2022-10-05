using System;

namespace _07._Projects_Creation
{
    internal class Projects_Creation
    {
        static void Main(string[] args)
        {
            // Input
            string name = Console.ReadLine();
            int projects = int.Parse(Console.ReadLine());

            // Calculate
            int hours = projects * 3;

            // Output
            Console.WriteLine($"The architect {name} will need {hours} hours to complete {projects} project/s.");

            // name = George ; projects = 4 ; "The architect George will need 12 hours to complete 4 project/s."
        }
    }
}