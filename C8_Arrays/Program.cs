using System;

namespace C8_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("how many siblings do you have?");
            var _NumberOfSiblings = Convert.ToInt32(Console.ReadLine());

            if (_NumberOfSiblings < 1) 
                Console.WriteLine("Okay. That's cool man.");
            else
            {
                string[] siblings = new string[_NumberOfSiblings];
                
                if (_NumberOfSiblings == 1)
                {
                    Console.Write("What is your sibling's name?");
                    siblings[0] = Console.ReadLine();
                }
                else
                {
                    for(var i=0; i < _NumberOfSiblings; i++)
                    {
                        if (i == 0)
                            Console.Write("What's your first sibling's name?");
                        else
                            Console.Write("And your next sibling's name is?");

                        siblings[i] = Console.ReadLine();
                    }

                }

                if (_NumberOfSiblings == 1)
                    Console.Write("Your sibling is ");
                else
                    Console.Write("Your siblings are ");

                foreach (var sibling in siblings)
                {
                    Console.Write($"{sibling}, ");
                }
            }
        }
    }
}
