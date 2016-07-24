using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Problem1_GenericBox
{
    public class Box<T>
    {
        private T storedData;
        public Box(T data)
        {
            this.storedData = data;
        }

        public override string ToString()
        {
            return $"{this.storedData.GetType().FullName}: {this.storedData}";
        }


    }
}
