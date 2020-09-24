using System;

namespace C1_WriteLine
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Martin";
            int age = 33;
            var city = "Örebro";
            var path = @"D:\Documents\Webbutveckling\Projekt\Lektion 3\document.txt";
            var json = "{\"firstName\":\"Martin\", \"lastName\":\"Boson\"}";
            // var json2 = @"{"firstName":"Martin", "lastName":"Boson"}"; //felaktig formatering

            var text2 = "welcome martin boson. you are 33 years old and lives in örebro";
            var text3 = String.Format("Welcome {0}. You are {1} years old and lives in {2}", name, age, city);

            Console.WriteLine(text3);
        }
    }
}