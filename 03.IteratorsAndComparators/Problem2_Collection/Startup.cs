using System;
using System.Collections.Generic;

namespace Problem2_Collection
{
    public class Startup
    {
        static void Main()
        {
            var consoleInput = Console.ReadLine();
            ListyIterator<string> iterrator = new ListyIterator<string>();
            List<string> logStrings = new List<string>();

            while (consoleInput != "END")
            {
                var commands = consoleInput.Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                switch (commands[0])
                {
                    case "Create":
                        if (commands.Length > 1)
                        {
                            for (int i = 1; i < commands.Length; i++)
                            {
                                iterrator.Add(commands[i]);
                            }
                        }
                        break;
                    case "Move":
                        logStrings.Add(iterrator.Move().ToString());
                        break;
                    case "PrintAll":
                        string resultString = String.Empty;
                        foreach (var element in iterrator)
                        {
                            resultString = resultString + element + " ";
                        }
                        logStrings.Add(resultString);
                        break;
                    case "Print":
                        logStrings.Add(iterrator.Print());
                        break;
                    case "HasNext":
                        logStrings.Add(iterrator.HasNext().ToString());
                        break;
                }

                consoleInput = Console.ReadLine();
            }

            foreach (var log in logStrings)
            {
                Console.WriteLine(log);
            }
        }
    }
}
