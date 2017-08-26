namespace GrokkingAlgorithms.Core.Recursion
{
    public class Key : IContainable
    {
        public bool IsKey()
        {
            return true;
        }

        public ISearchResult Search()
        {
            return this;
        }
    }
}