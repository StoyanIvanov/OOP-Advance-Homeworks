using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Problem1_ListyIterator
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        private readonly List<T> collection;
        private int indexCount;

        public ListyIterator()
        {
            this.collection = new List<T>();
            indexCount = 0;
        }

        public void Add(T element)
        {
            this.collection.Add(element);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this.collection.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public bool Move()
        {
            if (this.indexCount + 1 <= this.collection.Count-1)
            {
                this.indexCount++;
                return true;
            }
            return false;
        }

        public bool HasNext()
        {
            if (this.indexCount + 1 > this.collection.Count-1)
            {
                return false;
            }

            return true;
        }

        public string Print()
        {
            if (this.collection.Count>0)
            {
                return this.collection[this.indexCount].ToString();
            }

            return "Invalid Operation!";

        }
    }
}
