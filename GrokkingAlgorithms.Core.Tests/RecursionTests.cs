namespace GrokkingAlgorithms.Core.Tests
{
    using System.Collections.Generic;
    using GrokkingAlgorithms.Core.Recursion;
    using Xunit;

    public class RecursionTests
    {
        private readonly IContainable key = new Key();
        private readonly IContainable boxWithKey;

        public RecursionTests()
        {
            boxWithKey = new Box(new List<IContainable>() { key });
        }
        
        [Fact]
        public void GivenAKeyItKnowsItIsAKey()
        {
            Assert.Equal(true, key.IsKey());
        }

        [Fact]
        public void GivenAKeyItReturnsItselfWhenSearched()
        {
            Assert.Same(key, key.Search());
        }

        [Fact]
        public void GivenABoxItKnowsItsANotKey()
        {
            Assert.Equal(false, boxWithKey.IsKey());
        }

        [Fact]
        public void GivenABoxWithAKeyInsideThenTheKeyIsReturnedWhenSearched()
        {
            Assert.Same(key, boxWithKey.Search());
        }

        [Fact]
        public void GivenABoxWithBoxesInsideOfItEachBoxIsSearched()
        {
            var parentBox = new Box(new List<IContainable>() 
            { 
                new Box(), 
                new Box( new List<IContainable>() { boxWithKey }), 
                new Box()
            });
            
            Assert.Same(key, parentBox.Search());
        }
    }
}
