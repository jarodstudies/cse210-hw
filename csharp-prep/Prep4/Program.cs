using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep4 World!");

        Console.WriteLine("Eneter a list of numbers, enter 0 when finished.");

        List<int> numbers = new List<int>();

        int number = -1 ;

        while (number != 0)
        {

            Console.Write("Enter number: ");

            number = int.Parse(Console.ReadLine());
            
            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        int sum =  0;
        foreach (int userNumber in numbers)
        {
            sum += userNumber;
        }

        Console.WriteLine($"The total sum is: {sum}");

        float average = ((float)sum)/numbers.Count;
        Console.WriteLine ($"The average is: {average}");

        int max  = numbers[0];

        foreach (int userNumber in numbers)
        {
            if (userNumber > max)
            {
                max = userNumber;

            }
        }

        Console.WriteLine($"The max number is: {max}");
        
    }
}