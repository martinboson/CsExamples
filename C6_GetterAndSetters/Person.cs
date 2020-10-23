using System;
using System.Collections.Generic;
using System.Text;

namespace C6_GetterAndSetters
{
    class Person
    {

        public string Name { get; private set; } = "";
        public int Age => CalculateAge();
        public string City { get; set; }

        public DateTime DateOfBirth { get; set; }


        public void AskForName()
        {
            Console.Write("Welcome Dude! What's your name?");
            Name = Console.ReadLine(); // deklarera variabler när du använder dem
            Console.Write($"Sweet, {Name} :)");
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

        public void AskForDateOfBirth()
        {
            Console.Write("When were you born?");

            try
            {
                DateOfBirth = Convert.ToDateTime(Console.ReadLine());
            }
            catch
            {
                Console.Write("Sorry, format has to be 0000-00-00. When are you born?");
                try
                {
                    DateOfBirth = Convert.ToDateTime(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("You are dumb.");
                }
            }

            Console.WriteLine($"Cool, I am also {CalculateAge()}");
        }

        private int CalculateAge()
        {
            int _age = DateTime.Now.Year - DateOfBirth.Year;

            if (DateTime.Now.DayOfYear < DateOfBirth.DayOfYear)
                _age = Age - 1;

            return _age;
        }
    }
}
