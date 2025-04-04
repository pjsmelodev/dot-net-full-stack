using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    static class Calculate
    {
        static int count = 0;

        static Calculate()
        {
            count = 0;
        }

        public static int Increment()
        {
            count++;
            return count;
        }

        public static int Decrement()
        {
            count--;
            return count;
        }
    }
}
