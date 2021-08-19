﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Classes_Assignment
{
    public class Person
    {
        public string fName { get; set; }
        public string lName { get; set; }

        public virtual void SayName() 
        {
            Console.WriteLine($"Your name is {fName} {lName}");
        }
    }
}
