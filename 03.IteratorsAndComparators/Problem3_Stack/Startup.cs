using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem3_Stack
{
    public class Startup
    {
        static void Main()
        {
            var consoleInput = Console.ReadLine();
            StackImplementation<long> stack = new StackImplementation<long>();

            while (consoleInput != "END")
            {
                var commands = consoleInput.Trim().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                switch (commands[0])
                {
                    case "Push":

                        if (commands.Length > 1)
                        {
                            for (int i = 1; i < commands.Length; i++)
                            {
                                long number;
                                if (long.TryParse(commands[i], out number))
                                {
                                    stack.Push(number);
                                }
                            }

                        }
                        break;
                    case "Pop":
                        stack.Pop();
                        break;
                }


                consoleInput = Console.ReadLine();

            }

            if (stack.Any())
            {
                foreach (var record in stack.ForeachReversed())
                {
                    Console.WriteLine(record);
                }
                foreach (var record in stack.ForeachReversed())
                {
                    Console.WriteLine(record);
                }
            }
            else
            {
                Console.WriteLine("No elements");
            }


        }
    }
}
