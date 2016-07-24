using System;
using System.Collections.Generic;

namespace Problem5_GenericSwapMethodIntegers
{
    public class Startup
    {
        static void Main()
        {
            List<int> inputs = new List<int>();
            var numbersOfRecords = int.Parse(Console.ReadLine());

            for (int i = 0; i < numbersOfRecords; i++)
            {
                inputs.Add(int.Parse(Console.ReadLine()));
            }

            var indexes = Console.ReadLine().Trim().Split();
            var firstIndex = int.Parse(indexes[0]);
            var secondIndex = int.Parse(indexes[1]);
            var revertedList = RevertGenericList<int>.Revert(inputs, firstIndex, secondIndex);

            foreach (var element in revertedList)
            {
                Console.WriteLine($"{element.GetType().FullName}: {element}");
            }
        }
    }
}
