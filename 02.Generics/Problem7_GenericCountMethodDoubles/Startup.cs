using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Problem7_GenericCountMethodDoubles
{
    public class Startup
    {
        static void Main()
        {
            CultureInfo culture = new CultureInfo("en-US", false);
            List<Box<double>> dataList = new List<Box<double>>();
            var numbersOfRecords = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < numbersOfRecords; i++)
            {
                var number = Console.ReadLine();
                dataList.Add(new Box<double>(double.Parse(number, culture)));
            }

            var compare = Console.ReadLine();
            var compairValue = new Box<double>(double.Parse(compare, culture));
            Console.WriteLine(CompareByValue<double>(dataList, compairValue));

        }

        static int CompareByValue<T>(List<Box<T>> boxes, Box<T> compare) where T : IComparable<T>
        {

            return Enumerable.Count(boxes, e => e.Value.CompareTo(compare.Value) > 0);
        }
    }
}
