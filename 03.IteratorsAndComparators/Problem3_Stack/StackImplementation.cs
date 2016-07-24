using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3_Stack
{
    class StackImplementation<T> : IEnumerable<T>
    {
        private List<T> collection;

        public StackImplementation()
        {
            this.collection=new List<T>();
        }

        public void Push(T input)
        {
            this.collection.Add(input);
        }

        public void Pop()
        {
            int count = this.collection.Count;
            if (count>0)
            {
                this.collection.RemoveAt(count-1);
            }
        }

        public int Count()
        {
            return this.collection.Count;
        }

        public IEnumerable<string> ForeachReversed()
        {
            for (int i =this.collection.Count-1; i >= 0; i--)
            {
                yield return this.collection[i].ToString();
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.collection.Count; i++)
            {
                yield return this.collection[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
