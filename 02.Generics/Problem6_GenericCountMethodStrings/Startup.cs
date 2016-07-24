using System;
using System.Collections.Generic;
using Enumerable = System.Linq.Enumerable;

namespace Problem6_GenericCountMethodStrings
{
    public class Startup
    {
        static void Main()
        {
            List<Box<string>> dataList = new List<Box<string>>();
            var numbersOfRecords = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < numbersOfRecords; i++)
            {
                dataList.Add(new Box<string>(Console.ReadLine()));
            }

            var compairValue = new Box<string>(Console.ReadLine());
            Console.WriteLine((int) CompareByValue(dataList, compairValue));

        }

        static int CompareByValue<T>(List<Box<T>> boxes, Box<T> compare) where T : IComparable<T>
        {
            return Enumerable.Count(boxes, e => e.Value.CompareTo(compare.Value) > 0);
        }
    }
}
