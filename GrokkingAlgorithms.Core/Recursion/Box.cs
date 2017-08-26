using System;
using System.Collections.Generic;

namespace GrokkingAlgorithms.Core.Recursion
{
    public class Box : IContainable
    {
        private readonly List<IContainable> contents;

        // we instantiate a new empty list to avoid null checks/exceptions. if a significant number
        // of these objects are to be created, you could make this a singleton or static reference,
        // but we'll go with this implementation for clarity.  
        public Box() : this(new List<IContainable>())
        {

        }

        public Box(List<IContainable> contents)
        {
            if (contents == null)
            {
                throw new ArgumentNullException(nameof(contents));
            }

            this.contents = contents;
        }

        public bool IsKey()
        {
            return false;
        }

        public ISearchResult Search()
        {
            ISearchResult result = null;

            foreach (var item in contents)
            {
                result = item.IsKey() ?
                    item :
                    item.Search();
               
                if (result != null && result.IsKey())
                {
                    break;
                }
            }

            return result;
        }
    }
}