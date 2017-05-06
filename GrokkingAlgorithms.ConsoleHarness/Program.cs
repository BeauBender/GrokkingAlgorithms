using System;
using GrokkingAlgorithms.Core;

namespace GrokkingAlgorithms.ConsoleHarness
{
    class Program
    {
        static void Main(string[] args)
        {
            var toSearch = new[] { "a", "b", "c", "d", "e", "f" };
            var foundAt = new BinarySearch<string>().IndexOf(toSearch, "f");
            Console.WriteLine($"Found at {foundAt}.");

            Console.WriteLine("Hello World!");
        }
    }
}
