using System;

namespace _08.PetShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dfood = int.Parse(Console.ReadLine());
            int cfood = int.Parse(Console.ReadLine());
            double dprice = dfood * 2.50;
            double cprice = cfood * 4;
            double price = dprice + cprice;
            Console.WriteLine($"{price} lv.");
        }
    }
}
