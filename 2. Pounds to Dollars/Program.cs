using System;

namespace PoundsToDollars
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal pounds = decimal.Parse(Console.ReadLine());
            double dolarForPound = 1.31;
            decimal n = pounds * (decimal)dolarForPound;

            Console.WriteLine($"{n:f3}");
        }
    }
}