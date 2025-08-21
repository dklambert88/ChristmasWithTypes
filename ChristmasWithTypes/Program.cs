using System;

namespace ChristmasWithTypes
{
    class Program
    {
        static void Main()
        {
            var xmas = new Christmas();

            var xmasDay = Christmas.Day.Thursday;

            // Set Santa's name to Kris Kringle
            xmas.Santa = "Kris Kringle";

            // Insert 3 presents (strings)
            xmas.Presents = new string[3] { "Laptop", "Golf clubs", "Noise-cancelling headphones" };

            // Set the TreeHeight to 10
            xmas.TreeHeight = 10;

            Console.WriteLine($"This year christmas falls on {xmasDay} \n");
            Console.WriteLine($"Our tree will be {xmas.TreeHeight} feet high \n");
            Console.WriteLine("Here are the presents we would like:");

            foreach (var present in xmas.Presents)
            {
                Console.WriteLine($"    {present}");
            }

            Console.WriteLine($"\nWe like to call Santa, {xmas.Santa}");
        }
    }
}