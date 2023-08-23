using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.CustomDataTypeCollection
{
    public class Collection : CollectionBase
    {
        public void Add(Object item)
        {
            InnerList.Add(item);
        }

        public void Remove(Object item)
        {
            InnerList.Remove(item);
        }

        public new void Clear()
        {
            InnerList.Clear();
        }

        public new int Count()
        {
            return InnerList.Count;
        }

        public bool Contains(Object item)
        {
            return InnerList.Contains(item);
        }

        public void Insert(int index, Object item)
        {
            InnerList.Insert(index, item);
        }

        public int IndexOf(Object item)
        {
            return InnerList.IndexOf(item);
        }

        public new void RemoveAt(int index)
        {
            if(index < 0 && index >= InnerList.Count)
            {
                throw new IndexOutOfRangeException();
            }

            InnerList.RemoveAt(index);  
        }
    }
}
