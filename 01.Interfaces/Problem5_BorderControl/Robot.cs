using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5_BorderControl
{
    public class Robot:IEntity
    {
        public Robot(string name, string id)
        {
            this.Name = name;
            this.Id = id;
        }

        public string Id { get; private set; }
        public string Name { get; private set; }
    }
}
