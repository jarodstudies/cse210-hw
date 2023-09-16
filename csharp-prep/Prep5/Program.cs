using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");

        DisplayMessage();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int square = SquareNumber(userNumber);

        ShowResults(square, userName);


        static void DisplayMessage()
        {
            Console.WriteLine("Welcome to the programm.");
        }

        static string PromptUserName()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            return name;
        }

        static int PromptUserNumber()
        {
            Console.Write("Enter your favourite number: ");
            int number = int.Parse(Console.ReadLine());

            return number;
        }

        static int SquareNumber (int number)
        {
            int square = number * number;
            return square;
        }

        static void ShowResults (int squareNumber, string userName)

        {
            Console.WriteLine($"{userName}, the square root of your number is {squareNumber}.");
        }
    }
}