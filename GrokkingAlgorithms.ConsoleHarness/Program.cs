using System;
using GrokkingAlgorithms.Core;

namespace GrokkingAlgorithms.ConsoleHarness
{
    class Program
    {
        static void Main(string[] args)
        {
            ExecuteBinarySearch();
        }

        private static void ExecuteBinarySearch()
        {
            var toSearch = new[] { "a", "b", "c", "d", "e", "f" };
            var foundAt = new BinarySearch<string>().IndexOf(toSearch, "f");
            Console.WriteLine($"Found at {foundAt}.");
        }

        private static void ExecuteSelectionSort()
        {
            var toSort = new[] { int.MaxValue, 10, 3, 53, 6, 99, 100, int.MinValue };
            var sorted = new SelectionSort().Sort(toSort);
            Console.WriteLine("Sorted.");
        }
    }
}
