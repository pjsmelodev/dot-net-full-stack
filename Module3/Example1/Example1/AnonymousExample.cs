using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    public delegate void PrintMessage(string message);

    class AnonymousExample
    {
        public static void InvokeMethod()
        {
            PrintMessage printMessage = delegate (string message)
            {
                Console.WriteLine("Message: " + message);
            };
            printMessage("Hello, this is an anonymous method!");
        }
    }
}
