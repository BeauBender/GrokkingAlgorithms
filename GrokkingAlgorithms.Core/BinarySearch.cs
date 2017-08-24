namespace GrokkingAlgorithms.Core
{
    using System;

    public class BinarySearch<T> where T : IComparable
    {
        public int IndexOf(T[] toSearch, T toFind)
        {
            var foundAt = -1;
            var low = 0;
            var high = toSearch.Length - 1;

            while (low <= high)
            {
                var mid = (low + high) / 2;
                var found = toSearch[mid];

                var comparisonResult = found.CompareTo(toFind);
                if (comparisonResult == 0)
                {
                    foundAt = mid;
                    break;
                }

                if (comparisonResult > 0)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
                
            return foundAt;
        }
    }
}
