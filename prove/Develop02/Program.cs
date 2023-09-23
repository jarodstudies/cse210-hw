using System;
using System.IO;
//using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");

        int decision = -1;

        Journal myJournal = new Journal();
        myJournal._entries = new List<Entry>();

        

        while (decision != 6)
        {

        
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("What would you like to do? ");
        decision = int.Parse(Console.ReadLine());

        if (decision == 1)
        {

            Entry newEntry = new Entry();


            DateTime theCurrentTime = DateTime.Now;
            newEntry._date = theCurrentTime.ToShortDateString();
            
            PromptGenerator prompt =  new PromptGenerator();

            newEntry._promptText = prompt.GetRandomPrompt();
            Console.WriteLine(newEntry._promptText);
            

            Console.Write("<");
            newEntry._entryText = Console.ReadLine();

            myJournal.AddEntry(newEntry);

        }

        else if (decision == 2)
        {
            myJournal.DisplayAll();

        }

        else if (decision == 3)
        {
            Console.WriteLine("What is the file name: ");
            string fileName = Console.ReadLine();

            myJournal.LoadFromFile(fileName);

        }

        else if (decision == 4)
        {
            Console.WriteLine("Enter a file name: ");
            string fileName = Console.ReadLine();

            myJournal.SaveToFile(fileName);

        }

        else if (decision == 5 )
        {
            Console.WriteLine("\nThank you, Good Bye\n");

            break;
        }

        else 
        {
            Console.WriteLine("\nInvalid number, please enter a new number.\n");
        }

        }

    }
}