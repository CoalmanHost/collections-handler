using CollectionsHandler;
using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionsHandler
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ISorter<T>
    {
        void Sort(ICollection<T> collection);
    }
}
