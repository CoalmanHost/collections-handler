using CollectionsHandler;
using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionsHandler
{
    /// <summary>
    /// Bubble sort of an array
    /// </summary>
    public class BubbleSorter<T> : ISorter<T>
    {
        public void Sort(ICollection<T> collection)
        {
            IList<T> c;
            try
            {
                c = (IList<T>)collection;
            }
            catch (InvalidCastException)
            {
                throw new CollectionIsNotArrayTypeException();
            }
            for (int i = 0; i < c.Count - 1; i++)
            {
                for (int j = i + 1; j < collection.Count; j++)
                {
                    IComparable<T> a;
                    T b;
                    try
                    {
                        a = (IComparable<T>)c[i];
                        b = c[j];
                    }
                    catch (InvalidCastException)
                    {
                        throw;
                    }
                    if (a.CompareTo(b) > 0)
                    {
                        T temp = c[i];
                        c[i] = c[j];
                        c[j] = temp;
                    }
                }
            }
        }
        public void Sort(IList<T> collection, IComparer<T> comparer)
        {
            IList<T> c;
            if (TryCollectionType(collection, out c))
            {
                for (int i = 0; i < c.Count - 1; i++)
                {
                    for (int j = i + 1; j < collection.Count; j++)
                    {
                        if (comparer.Compare(c[j], c[i]) > 0)
                        {
                            T temp = c[i];
                            c[i] = c[j];
                            c[j] = temp;
                        }
                    }
                }
            }
        }
        bool TryCollectionType(ICollection<T> collection, out IList<T> listTypeCollection)
        {
            listTypeCollection = collection as IList<T>;
            return collection is IList<T>;
        }
    }
}
