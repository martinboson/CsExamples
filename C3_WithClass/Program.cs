using System;

namespace C3_WithClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();

            Console.Write("Welcome Dude! What's your name?");
            person.Name = Console.ReadLine(); // deklarera variabler när du använder dem
            Console.Write($"Sweet, {person.Name} :) How are you man?");
            // int age = Convert.ToInt32(Console.ReadLine());

            try
            {
                person.Age = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Sorry! You must use digits!");
                Console.Write($"Sweet, {person.Name} :) How old are you?");
                person.Age = Convert.ToInt32(Console.ReadLine());
            }
            finally
            {
                Console.WriteLine($"you are {person.Age}, thank you, {person.Name}!");
            }

            Console.WriteLine($"Your name contains {person.Name.Length} characters!");
            Console.Write($"Where do you live?");
            person.City = Console.ReadLine();
            Console.WriteLine($"Sweet! My Brother lives in {person.City}");

        }
    }
}
