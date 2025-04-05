using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    internal class User
    {
        private string name;
        private string companyName;
        private int age;
        // Auto-implemented property
        private string City { get; set; }

        public User()
        {
            companyName = "ABC";
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // Read-Only Property
        public string CompanyName
        {
            get { return companyName; }
        }

        // Read-Write Property
        // Just has a set method

        public int Age
        {
            get { return age; }
            set 
            {
                if (value < 18)
                    throw new ArithmeticException("Invalid Age");
                age = value;
            }
        }



    }
}
