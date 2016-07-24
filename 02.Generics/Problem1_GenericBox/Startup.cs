using System;

namespace Problem1_GenericBox
{
    public class Startup
    {
        static void Main()
        {
            Box<int> intBox=new Box<int>(123123);
            Console.WriteLine(intBox.ToString());

            Box<string> stringBox=new Box<string>("life in a box");
            Console.WriteLine(stringBox.ToString());
        }
    }
}
