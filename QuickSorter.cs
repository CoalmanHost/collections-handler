using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionsHandler
{
    /// <summary>
    /// Quick sort of an array
    /// </summary>
    public class QuickSorter<T> : ISorter<T>
    {
        int partition(IList<T> array, int low, int high)
        {
            int p = (new Random()).Next(low, high);
            for (int i = low; i < p; i++)
            {
                while (((IComparable<T>)array[i]).CompareTo(array[p]) > 0)
                {
                    T temp = array[i];
                    array[i] = array[p - 1];
                    array[p - 1] = array[p];
                    array[p] = temp;
                    p--;
                }
            }
            for (int i = p + 1; i <= high; i++)
            {
                while (((IComparable<T>)array[i]).CompareTo(array[p]) < 0)
                {
                    T temp = array[i];
                    array[i] = array[p + 1];
                    array[p + 1] = array[p];
                    array[p] = temp;
                    p++;
                }
            }
            return p;
        }

        void qsort(IList<T> array, int low, int high)
        {
            if (low < high)
            {
                int p = partition(array, low, high);
                qsort(array, low, p - 1);
                qsort(array, p + 1, high);
            }
        }

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
            if (c.Count <= 0)
            {
                return;
            }
            if (c[0] as IComparable<T> == null)
            {
                return;
            }
            qsort(c, 0, c.Count - 1);
        }
    }
}
