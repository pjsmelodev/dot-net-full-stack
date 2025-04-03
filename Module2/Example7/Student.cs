using System;

namespace coreObjectOrientedConcepts
{
    internal class Student
    {
        // Data Members
        int studentID;
        string studentName;

        // Member Functions
        public void DisplayDetails()
        {
            Console.WriteLine("Student ID: " + studentID);
            Console.WriteLine("Student Name: " + studentName);
        }
    }
}