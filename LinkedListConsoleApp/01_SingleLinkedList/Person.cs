﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_SingleLinkedList
{
    internal class Person
    {
        public int Age { get; set; }

        public override string ToString()
        {
            return "Person Age: " + Age;
        }

    }
}
