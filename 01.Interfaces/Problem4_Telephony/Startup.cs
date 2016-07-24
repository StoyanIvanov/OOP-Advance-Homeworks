using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace Problem4_Telephony
{
    public class Startup
    {
        static void Main()
        {
            Smartphone smartphone = new Smartphone();
            var firstLine = Console.ReadLine().Split();
            var secondLine = Console.ReadLine().Split();

            foreach (var element in firstLine)
            {
                Console.WriteLine(smartphone.AddCall(element));
            }

            foreach (var element in secondLine)
            {
                Console.WriteLine(smartphone.Browse(element));

            }

        }
    }
}
