using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Declaring a Delegate
delegate int CalculateDelegate(int num);

namespace Example1
{
    class DelegateExample
    {
        static int number = 100;
        
        public static int Addition(int num)
        {
            number = number + num;
            return number;
        }

        public static int Multiplication(int num)
        {
            number = number * num;
            return number;
        }

        public static int getNumber()
        {
            return number;
        }
    }
}
