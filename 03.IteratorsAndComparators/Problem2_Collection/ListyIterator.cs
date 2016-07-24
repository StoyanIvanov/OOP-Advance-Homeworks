using System.Collections;
using System.Collections.Generic;

namespace Problem2_Collection
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        private readonly List<T> collection;
        private int indexCount;

        public ListyIterator()
        {
            this.collection = new List<T>();
            this.indexCount = 0;
        }

        public void Add(T element)
        {
            this.collection.Add(element);
        }

        public IEnumerator<T> GetEnumerator()
        {

            for (int i = 0; i < this.collection.Count; i++)
            {
                yield return this.collection[i];
            }
        }

        public bool Move()
        {
            if (this.indexCount + 1 <= this.collection.Count - 1)
            {
                this.indexCount++;
                return true;
            }
            return false;
        }

        public bool HasNext()
        {
            if (this.indexCount + 1 > this.collection.Count - 1)
            {
                return false;
            }

            return true;
        }

        public string Print()
        {
            if (this.collection.Count > 0)
            {
                return this.collection[this.indexCount].ToString();
            }

            return "Invalid Operation!";

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
