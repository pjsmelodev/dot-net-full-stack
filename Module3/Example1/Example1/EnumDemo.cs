using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    enum WeekDays: byte
    {
        Monday = 5,     // 0
        Tuesday = 10,    // 1
        Wednesday = 15,  // 2
        Thursday = 25,   // 3
        Friday,     // 4
        Saturday = 30,   // 5
        Sunday      // 6
    }

    internal class EnumDemo
    {
        public void Display()
        {
            Console.WriteLine(WeekDays.Monday);
            int day = (int)WeekDays.Monday;
            Console.WriteLine(WeekDays.Monday + " " + day);

            Console.WriteLine(WeekDays.Tuesday);
            day = (int)WeekDays.Tuesday;
            Console.WriteLine(WeekDays.Tuesday + " " + day);

            Console.WriteLine(WeekDays.Wednesday);
            day = (int)WeekDays.Wednesday;
            Console.WriteLine(WeekDays.Wednesday + " " + day);

            Console.WriteLine(WeekDays.Thursday);
            day = (int)WeekDays.Thursday;
            Console.WriteLine(WeekDays.Thursday + " " + day);

            Console.WriteLine(WeekDays.Friday);
            day = (int)WeekDays.Friday;
            Console.WriteLine(WeekDays.Friday + " " + day);

            Console.WriteLine(WeekDays.Saturday);
            day = (int)WeekDays.Saturday;
            Console.WriteLine(WeekDays.Saturday + " " + day);

            Console.WriteLine(WeekDays.Sunday);
            day = (int)WeekDays.Sunday;
            Console.WriteLine(WeekDays.Sunday + " " + day);
        }
    }
}
