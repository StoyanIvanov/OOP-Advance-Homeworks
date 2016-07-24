using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem6_BirthdayCelebrations
{
    public class Startup
    {
        static void Main()
        {
            List<iBe> entities = new List<IEntity>();
            var input = Console.ReadLine();

            while (input != "End")
            {
                var elements = input.Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (elements.Length == 3)
                {
                    Citizen people = new Citizen(elements[0], elements[2], elements[1]);
                    entities.Add(people);
                }

                if (elements.Length == 2)
                {
                    Robot robot = new Robot(elements[0], elements[1]);
                    entities.Add(robot);
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            foreach (var entity in entities)
            {

                if (entity.Id.Substring(entity.Id.Length - (input.Length)) == input)
                {
                    Console.WriteLine(entity.Id);
                }

            }
        }
    }
}
