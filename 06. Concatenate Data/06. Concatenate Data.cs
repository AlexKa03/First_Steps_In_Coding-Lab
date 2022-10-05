using System;

namespace _06._Concatenate_Data
{
    internal class Concatenate_Data
    {
        static void Main(string[] args)
        {
            // Inputs
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string town = Console.ReadLine();

            // Output
            Console.WriteLine($"You are {firstName} {lastName}, a {age}-years old person from {town}.");

            // firstName = Alex ; lastName = Kadiyski ; age = 19 ; town = Burgas ; "You are Alex Kadiyski, a 18-years old person from Burgas."
        }
    }
}
