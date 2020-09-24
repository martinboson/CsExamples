using System;

namespace C2_Readline
{
    class Program
    {
        static void Main(string[] args)
        {

            int age = 0;
            Console.Write("Welcome Dude! What's your name?");
            string name = Console.ReadLine(); // deklarera variabler när du använder dem
            Console.Write($"Sweet, {name} :) How are you man?");
            // int age = Convert.ToInt32(Console.ReadLine());

            try
            {
                age = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Sorry! You must use digits!");
                Console.Write($"Sweet, {name} :) How old are you?");
                age = Convert.ToInt32(Console.ReadLine());
            }
            finally
            {
                Console.WriteLine($"you are {age}, thank you, {name}!");
            }

            Console.WriteLine($"Your name contains {name.Length} characters!");
            Console.Write($"Where do you live?");
            var city = Console.ReadLine();
            Console.WriteLine($"Sweet! My Brother lives in {city}");



        }
    }
}
