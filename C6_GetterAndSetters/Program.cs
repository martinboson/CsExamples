using System;

namespace C6_GetterAndSetters
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.AskForName();
            person.AskForDateOfBirth();
        }
    }
}
