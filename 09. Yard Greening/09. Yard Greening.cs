using System;

namespace _09._Yard_Greening
{
    internal class Yard_Greening
    {
        static void Main(string[] args)
        {
            // Input
            double sqMeters = double.Parse(Console.ReadLine());

            // Calculate
            double price = sqMeters * 7.61;
            double discount = price * 0.18;

            // Output
            Console.WriteLine($"The final price is: {price - discount} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
        }
    }
}
