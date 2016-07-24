using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem6_BirthdayCelebrations
{
    class Robot:IEntity
    {
        public Robot(string name,string id)
        {
            this.Name = name;
            this.Id = id;
        }
        public string Name { get; }
        public string Id { get; }
    }
}
