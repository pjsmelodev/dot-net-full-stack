using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    internal partial class Employee
    {
        public partial void DisplayDetails()
        {
            Console.WriteLine("Employee ID: " + this.EmpId);
            Console.WriteLine("Employee Name: " + this.EmpName);
        }
    }
}
