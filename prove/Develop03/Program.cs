using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop03 World!");

        string scripture = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";

        Reference newReference = new Reference("John", 3, 16);
        Console.WriteLine();

        Console.WriteLine($"{newReference.GetDipslayText()}{scripture}");

        Scripture hiddenScripture = new Scripture(newReference,scripture);

        //Console.Clear();

        while (true)
        {
            
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish: ");
            string userChoice = Console.ReadLine();

            if (userChoice == "Quit")
            {
                break;
            }

            else if (hiddenScripture.IsCompletelyHidden() is true)
            {
                break;

            }

            else 
            {

                Console.WriteLine("\nHow many words would you like to hide: ");
                int numberToHide = int.Parse(Console.ReadLine());

                hiddenScripture.HideRandomWords(numberToHide);

                Console.Clear();

                string hiddenText = hiddenScripture.GetDipslayText();
                Console.WriteLine(hiddenText);
                
            }

        }
    }
}