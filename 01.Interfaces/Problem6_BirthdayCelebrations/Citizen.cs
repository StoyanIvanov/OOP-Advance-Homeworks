using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem6_BirthdayCelebrations
{
    class Citizen:IEntity,IBeing
    {
        public Citizen(string name,string age, string id, string date)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.BurthDate = date;
        }

        public string Name { get; private set; }
        public string Id { get; private set; }
        public string BurthDate { get; private set; }

        public string Age { get; private set; }
    }
}
