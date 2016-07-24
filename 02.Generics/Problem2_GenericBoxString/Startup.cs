using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Problem1_GenericBox;

namespace Problem2_GenericBoxString
{
    public class Startup
    {
        static void Main()
        {

            var firtInput = int.Parse(Console.ReadLine());
            List<Box<String>> boxes=new List<Box<String>>();

            for (int i = 0; i < firtInput; i++)
            {
                boxes.Add(new Box<string>(Console.ReadLine()));
            }

            foreach (var box in boxes)
            {
                Console.WriteLine(box.ToString());
            }
        }
    }
}
