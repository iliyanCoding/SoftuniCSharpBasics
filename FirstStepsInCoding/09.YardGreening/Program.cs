using System;

namespace _09.YardGreening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double area = double.Parse(Console.ReadLine());
            Console.WriteLine($"The final price is: {(area * 7.61) - (0.18 * (area * 7.61))} lv.");
            Console.WriteLine($"The discount is: {0.18 * (area * 7.61)} lv.");
        }
    }
}
