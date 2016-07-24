using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5_BorderControl
{
    public class Citizen:IEntity
    {
        public Citizen(string name, string id, string age)
        {
            this.Name = name;
            this.Id = id;
            this.Age = age;
        }

        public string Id { get; private set; }
        public string Name { get; }
        public string Age { get; private set; }
    }
}
