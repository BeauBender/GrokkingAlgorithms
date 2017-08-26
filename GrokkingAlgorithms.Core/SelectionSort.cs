namespace GrokkingAlgorithms.Core
{
    using System;
    using System.Collections.Generic;
    public class SelectionSort
    {
        public T[] Sort<T>(T[] input) where T : IComparable
        {
            T[] toReturn = null;

            if (input != null)
            {
                var currentlySmallestValue = input[0];
                var toSort = new List<T>(input);
                toReturn = new T[input.Length];

                // You could remove this if you chose to internally use a List<T> for the return type and then 
                // transform it to an array when returning.
                var currentIndex = 0;
                
                while (toSort.Count > 0)
                {
                    var smallestIndex = FindSmallestIndex(toSort);

                    currentlySmallestValue = toSort[smallestIndex];
                    toReturn.SetValue(currentlySmallestValue, currentIndex++);
                    toSort.Remove(currentlySmallestValue);
                }
            }
 
            return toReturn;
        }

        private int FindSmallestIndex<T>(List<T> input) where T : IComparable
        {
            var toReturn = 0;
            T smallestValue = input[0];
            
            for (var i = 0; i < input.Count; i++)
            {
                if (input[i].CompareTo(smallestValue) < 0)
                {
                    smallestValue = input[i];
                    toReturn = i;
                }
            }

            return toReturn;
        }

        private T[] BuildCleanedArray<T>(T[] input, System.Collections.Generic.HashSet<int> indicesToSkip)
        {
            var toReturn = new List<T>();

            for (int i = 0; i < input.Length; i++)
            {
                if (!indicesToSkip.Contains(i))
                {
                    toReturn.Add(input[i]);
                }
            }

            return toReturn.ToArray();
        }
    }
}