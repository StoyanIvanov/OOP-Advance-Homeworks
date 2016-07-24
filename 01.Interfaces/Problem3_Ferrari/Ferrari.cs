using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3_Ferrari
{
    public class Ferrari:ICar
    {
        public Ferrari(string driverName)
        {
            this.Driver = driverName;
            this.Model = "488-Spider";
        }

        public string Model { get; private set; }
        public string Driver { get; private set; }
        public string Break()
        {
            return "Brakes!";
        }

        public string PushGas()
        {
            return "Zadu6avam sA!";
        }
    }
}
