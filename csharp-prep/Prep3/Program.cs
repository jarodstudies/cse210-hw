using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep3 World!");

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,50);

        int guess = -1;
        
        while (number != guess)
        {

            Console.Write("Enter your guess: ");
            guess = int.Parse(Console.ReadLine());

            if (number == guess)
        {
            Console.WriteLine("You guessed the number.");
        }

        else if (number > guess)
        {
            Console.WriteLine("You need to guess higher.");
        }

        else if (number < guess)
        {
            Console.WriteLine("You need to guess lower.");
        }
     
        }
    }
}