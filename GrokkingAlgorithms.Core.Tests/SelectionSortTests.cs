namespace GrokkingAlgorithms.Core.Tests
{
    using System.Linq;
    using Xunit;

    public class SelectionSortTests
    {
        private readonly int[] toSort = new[] { 5, 3, 1, 1, 2, 4, 11, 21 };
        private readonly SelectionSort<int> sorter = new SelectionSort<int>();

        [Fact]
        public void ReturnsNullWhenGivenANullInput()
        {
            Assert.Null(sorter.Sort(null));
        }

        [Fact]
        public void ReturnsArrayOfSameSizeAsInput()
        {
            var sorted = sorter.Sort(this.toSort);
            Assert.Equal(sorted.Length, toSort.Length);
        }

        [Fact]
        public void ReturnsSortedArrayOfValues()
        {
            var expected = new[] { 1, 1, 2, 3, 4, 5, 11, 21 };
            var actual = sorter.Sort(toSort);
            Assert.Equal(expected, actual);
        }
    }
}
