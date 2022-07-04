using System;

namespace _06.ConcatenateData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fname = Console.ReadLine();
            string lname = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string town = Console.ReadLine();
            Console.WriteLine($"You are {fname} {lname}, a {age}-years old person from {town}.");
        }
    }
}
