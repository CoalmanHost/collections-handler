using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionsHandler
{
    public class CollectionIsNotArrayTypeException : Exception
    {
        public CollectionIsNotArrayTypeException() { }
        public CollectionIsNotArrayTypeException(string message) : base(message) { }
    }
}
