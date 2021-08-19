using System;

namespace Abstract_Classes_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
           Employee Sample = new Employee();
            Sample.fName = "Sample";
            Sample.lName = "Student";

            Sample.SayName();
        }
    }
}
