using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop04 World!");

        while(true)
        {

            Console.Clear();

            Console.WriteLine("Menu Options");
            Console.WriteLine(" 1: Start Breathing Activity");
            Console.WriteLine(" 2: Start Reflecting Activity");
            Console.WriteLine(" 3: Start Listening Activity");
            Console.WriteLine(" 4: Quit");
            Console.Write("Select a choice from the menu: ");
            int userChoice = int.Parse(Console.ReadLine());

            if (userChoice == 1)
            {
                BreathingActivity newActivity = new BreathingActivity();
                
                newActivity.DisplayStartingMessage();
                newActivity.Run();
                newActivity.DisplayEndingMessage();

            }

            else if (userChoice == 2)
            {
                ReflectingActivity newActivity = new ReflectingActivity();

                newActivity.DisplayStartingMessage();
                newActivity.Run();
                newActivity.DisplayEndingMessage();
            }

            else if (userChoice == 3)
            {
                ListeningActivity newActivity = new ListeningActivity();

                newActivity.DisplayStartingMessage();
                newActivity.Run();
                newActivity.DisplayEndingMessage();
            }

            else if (userChoice == 4)
            {
                break;
            }

            else
            {
                Console.WriteLine("You have entered an incorrect value, kindly choose again. Thank you");
            }

        }
    }
}