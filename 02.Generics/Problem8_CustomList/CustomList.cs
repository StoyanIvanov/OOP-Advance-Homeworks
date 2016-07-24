using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem8_CustomList
{
    public class CustomList<T> where T : IComparable<T>
    {
        private List<T> data;
        private int count;

        public CustomList()
        {
            this.data=new List<T>();
            this.count = 0;
        }

        public List<T> GetData {
            get { return this.data; }
            private set { }
        }

        public void Add(T element)
        {
            data.Add(element);
            this.count++;
        }

        public T Remove<T>(int index)
        {
            if (index>this.data.Count && index<0)
            {
               throw new ArgumentOutOfRangeException();
            }
            var value = data[index];
            data.RemoveAt(index);
            this.count--;
            return (T)Convert.ChangeType(value, typeof(T));
        }

        public bool Contains(T element)
        {
            if (data.Contains(element))
            {
                return true;
            }
            return false;
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            if (firstIndex<0 || secondIndex>this.data.Count-1)
            {
                throw new ArgumentOutOfRangeException();
            }
            data.Reverse(firstIndex, secondIndex+1);
        }

        public int CountGreaterThan(T element)
        {
            int indexElement= data.IndexOf(element)+1;
            int greaterCount=data.Count - indexElement;

            return greaterCount;
        }

        public T Max()
        {
            return data.Max();
        }

        public T Min()
        {
            return data.Min();
        }

        public int Count()
        {
            return count;
        }
    }
}
