using System;
using System.Collections.Generic;

namespace Problem4_GenericSwapMethodStrings
{
    public class Startup
    {
        static void Main()
        {
            List<string> inputs = new List<string>();
            var numbersOfRecords = int.Parse(Console.ReadLine());

            for (int i = 0; i < numbersOfRecords; i++)
            {
                inputs.Add(Console.ReadLine());
            }

            var indexes = Console.ReadLine().Trim().Split();
            var firstIndex = int.Parse(indexes[0]);
            var secondIndex = int.Parse(indexes[1]);
            var revertedList = RevertGenericList<string>.Revert(inputs,firstIndex,secondIndex);

            foreach (var element in revertedList)
            {
                Console.WriteLine($"{element.GetType().FullName}: {element}");
            }
        }

    }
}
