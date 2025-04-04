using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    static class IntExtensions
    {
        public static bool IsGreaterThan(this int number, int value)
        {
            return number > value;
        }
    }
}
