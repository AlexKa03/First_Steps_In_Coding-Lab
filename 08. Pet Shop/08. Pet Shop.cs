using System;

namespace _08._Pet_Shop
{
    internal class Pet_Shop
    {
        static void Main(string[] args)
        {
            // Input
            int dogs = int.Parse(Console.ReadLine());
            int neighborAnimals = int.Parse(Console.ReadLine());

            // Calculate
            double moneyDogs = dogs * 2.5;
            int moneyNeighbor = neighborAnimals * 4;
            double total = moneyNeighbor + moneyDogs;

            // Output
            Console.WriteLine($"{total} lv.");

            // dogs = 5 ; neighborAnimals = 4 ; "28.5 lv."
        }
    }
}
