using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem6_BirthdayCelebrations
{
    class Pet : IBeing
    {
        public Pet(string name, string date)
        {
            this.Name = name;
            this.BurthDate = date;
        }

        public string Name { get; private set; }
        public string BurthDate { get; private set; }

    }
}
