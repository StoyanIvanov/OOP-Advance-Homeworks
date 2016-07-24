using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem6_GenericCountMethodStrings
{
    public class Box<T> where T:IComparable<T>
    {
        private T value;

        public Box(T value)
        {
            this.value = value;
        }

        public T Value {
            get { return this.value; }
            private set { }
        }

    }
}
