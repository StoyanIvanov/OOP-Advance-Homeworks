using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1_GenericBox
{
    public class Box<T>
    {
        private T storedData;
        public Box(T value)
        {
            this.storedData = value;
        }

        public override string ToString()
        {
            return $"{this.storedData.GetType().Name}: {this.storedData}";
        }
    }
}
