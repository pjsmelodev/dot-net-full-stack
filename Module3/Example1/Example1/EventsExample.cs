using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    // The Publisher Model
    class EventsExample
    {
        // Declare Delegate
        public delegate void delegate_OddNumber();
        // Declare Event
        public event delegate_OddNumber event_OddNumber;

        public void Addition()
        {
            int num1 = 100;
            int num2 = 200;
            int result = num1 + num2;
            Console.WriteLine("Addition: " + result);
            if (result % 2 != 0 && event_OddNumber != null)
            {
                // Raised Event
                event_OddNumber();
            }
        }
    }
}
