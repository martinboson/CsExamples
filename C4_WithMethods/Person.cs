using System;
using System.Collections.Generic;
using System.Text;

namespace C4_WithMethods
{
    class Person
    {

        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }


        public void AskForName()
        {
            Console.Write("Welcome Dude! What's your name?");
            Name = Console.ReadLine(); // deklarera variabler när du använder dem
            Console.Write($"Sweet, {Name} :)");
        }
        public void AskForAge()
        {
            Console.Write($"How old are you?");

            try
            {
                Age = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Sorry! You must use digits!");
                Console.Write($"Sweet, {Name} :) How old are you?");
                Age = Convert.ToInt32(Console.ReadLine());
            }
            finally
            {
                Console.WriteLine($"you are {Age}, thank you, {Name}!");
            }
        }
        public void NameLength()
        {
            Console.WriteLine($"Your name contains {Name.Length} characters!");
        }
        public void AskForCity()
        {
            Console.Write($"Where do you live?");
            City = Console.ReadLine();
            Console.WriteLine($"Sweet! My Brother lives in {City}");
        }
    }
}
