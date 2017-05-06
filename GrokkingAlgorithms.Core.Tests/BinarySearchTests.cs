namespace GrokkingAlgorithms.Core.Tests
{
    using Xunit;

    public class BinarySearchTests
    {
        private readonly int[] toSearch = new[] { 1, 3, 5, 7, 9 };
        private readonly BinarySearch<int> search = new BinarySearch<int>();

        [Fact]
        public void ReturnsFoundItemWhenPresent()
        {
            AssertScenario(5, 2);
        }

        [Fact]
        public void ReturnsNegativeOneWhenNotFound()
        {
            AssertScenario(10, -1);
        }

        private void AssertScenario(int toFind, int expected)
        {
            var actual = search.IndexOf(toSearch, toFind);
            Assert.Equal(expected, actual);
        }
    }
}
