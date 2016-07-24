using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2_MultipleImplementation
{
    public class Citizen : IPerson, IIdentifiable, IBirthable
    {

        public Citizen(string name, int age, string id, string birthdate)
        {
            this.Name = name;
            this.Age = age;
            this.id = id;
            this.Birthdate = birthdate;
        }

        public string id { get; private set; }
        public string Birthdate { get; private set; }
        public string Name { get; }
        public int Age { get; }
    }
}
