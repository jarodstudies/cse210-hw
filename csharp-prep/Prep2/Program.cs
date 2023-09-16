using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep2 World!");

        Console.Write("Enter in your grade percentage? ");
        string  userInput = Console.ReadLine();
        int percent = int.Parse(userInput);

        string letter = " ";


        if (percent >= 90)
        {
            //Console.WriteLine("You got an A congratulations!!");
            letter = "A";
        }

        else if (percent >= 80)
        {
            //Console.WriteLine("You got a B Well Done!");
            letter = "B";
        }

        else if (percent >= 70)
        {
            //Console.WriteLine("You got a C Good Job.");
            letter = "C";
        }

        else if (percent >= 60)
        {
            //Console.WriteLine("You got a D.");
            letter = "D";
        }

        else 
        {
            //Console.WriteLine("You got a F you need to work harder.");
            letter = "F";
        }

        Console.WriteLine($"You got a {letter}.");

        if (percent >= 70)
        {
            Console.WriteLine("Congratulations you passed!!");
        }
        else{
            Console.WriteLine("You were not able to meet the mark, but keep workiing hard and you will get there.");
        }

    }
}