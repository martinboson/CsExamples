using System;

namespace C4_WithMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();

            person.AskForName();

            person.NameLength();

            person.AskForAge();

            person.AskForCity();
        }
    }
}
