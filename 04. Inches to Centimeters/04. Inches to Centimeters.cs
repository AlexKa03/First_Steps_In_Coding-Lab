using System;

namespace _04._Inches_to_Centimeters
{
    internal class Inches_to_Centimeters
    {
        static void Main(string[] args)
        {
            // Input
            double inch = double.Parse(Console.ReadLine());

            // Calculate
            double cant = inch * 2.54;

            // Output
            Console.WriteLine(cant);

            // inch = 10 ; cant = 25.4
        }
    }
}
