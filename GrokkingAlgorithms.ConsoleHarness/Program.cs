using System;
using System.Collections.Generic;
using GrokkingAlgorithms.Core;
using GrokkingAlgorithms.Core.Recursion;

namespace GrokkingAlgorithms.ConsoleHarness
{
    class Program
    {
        static void Main(string[] args)
        {
            ExecuteBinarySearch();
            ExecuteSelectionSort();
            FindTheKeyRecursively();
            
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        private static void ExecuteBinarySearch()
        {
            var toSearch = new[] { "a", "b", "c", "d", "e", "f" };
            var foundAt = new BinarySearch<string>().IndexOf(toSearch, "f");
            Console.WriteLine($"Found at { foundAt }.");
        }

        private static void ExecuteSelectionSort()
        {
            var toSort = new[] { int.MaxValue, 10, 3, 53, 6, 99, 100, int.MinValue };
            var sorted = new SelectionSort().Sort(toSort);
            Console.WriteLine("Selection sorted.");
        }

        public static void FindTheKeyRecursively()
        {
            var boxWithKey = new Box(new List<IContainable>() { new Box(), new Box(), new Key(), new Box() });
            var parentBox = new Box(new List<IContainable> { boxWithKey });
            Console.WriteLine($"Found key { parentBox.Search().IsKey() }");
        }
    }
}
