using System;

namespace _01._Convert_Meters_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal meters = decimal.Parse(Console.ReadLine());
            decimal km = meters / 1000;
            Console.WriteLine($"{km:f2}");
        }
    }
}
