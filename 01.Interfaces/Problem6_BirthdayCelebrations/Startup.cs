using System;
using System.Collections.Generic;
using System.Linq;
using Problem6_BirthdayCelebrations;

namespace Problem6_BirthdayCelebrations
{
    public class Startup
    {
        static void Main()
        {
            List<IBeing> entities = new List<IBeing>();
            var input = Console.ReadLine();

            while (input != "End")
            {
                var elements = input.Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (elements.Length == 5)
                {
                    Citizen people = new Citizen(elements[1],elements[2],elements[3],elements[4]);
                    entities.Add(people);
                }

                if (elements.Length == 3)
                {
                    Pet dog = new Pet(elements[1], elements[2]);
                    entities.Add(dog);
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            foreach (var entity in entities)
            {
                if (entity.BurthDate.Split('/').Length==3 && entity.BurthDate.Substring(entity.BurthDate.Length - (input.Length)) == input)
                {
                    Console.WriteLine(entity.BurthDate);
                }

            }

        }
    }
}
