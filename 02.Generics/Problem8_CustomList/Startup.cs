using System;
using System.Collections.Generic;

namespace Problem8_CustomList
{
    public class Startup
    {
        static void Main()
        {

            var input = Console.ReadLine();
            var logResuts = new List<string>();
            var box=new CustomList<string>();

            while (input != "END")
            {
                var inputElements = input.Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                switch (inputElements[0])
                {
                    case "Add":
                        box.Add(inputElements[1]);
                        break;
                    case "Remove":
                        var returnedElement = box.Remove<string>(int.Parse(inputElements[1]));
                        logResuts.Add(returnedElement);
                        break;
                    case "Contains":
                        if (box.Contains(inputElements[1]))
                        {
                            logResuts.Add("True");
                        }
                        else
                        {
                            logResuts.Add("False");
                        }

                        break;
                    case "Swap":
                        box.Swap(int.Parse(inputElements[1]),int.Parse(inputElements[2]));
                        break;
                    case "Greater":
                        int result = box.CountGreaterThan(inputElements[1]);
                        logResuts.Add(result.ToString());
                        break;
                    case "Max":
                        logResuts.Add(box.Max());
                        break;
                    case "Min":
                        logResuts.Add(box.Min());
                        break;
                    case "Print":
                        foreach (var data in box.GetData)
                        {
                            logResuts.Add(data);
                        }
                        break;
                }

                input = Console.ReadLine();
            }

            foreach (var log in logResuts)
            {
                Console.WriteLine(log);
            }
        }
    }
}
