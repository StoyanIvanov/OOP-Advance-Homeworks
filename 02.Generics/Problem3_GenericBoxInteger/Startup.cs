using System;
using System.Collections.Generic;
using Problem1_GenericBox;

namespace Problem3_GenericBoxInteger
{
    public class Startup
    {
        static void Main()
        {

            var firtInput = int.Parse(Console.ReadLine());
            List<Box<int>> boxes = new List<Box<int>>();

            for (int i = 0; i < firtInput; i++)
            {
                boxes.Add(new Box<int>(int.Parse(Console.ReadLine())));
            }

            foreach (var box in boxes)
            {
                Console.WriteLine(box.ToString());
            }
        }
    }
}
