﻿using System;

namespace C7_GettersAndSettersV2
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.AskForDateOfBirth();
            person.Age = 12; // set
            Console.WriteLine(person.Age); // get
        }
    }
}
