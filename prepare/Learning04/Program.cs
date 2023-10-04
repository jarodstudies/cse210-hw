using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning04 World!");

        Assignment assignment1 = new Assignment("Fractions", "Jarod Ramos");
        Console.WriteLine(assignment1.GetSummary());
        Console.WriteLine();

        MathAssignment mathAssignment1 = new MathAssignment("7.3", "8-19", "Fractions", "Jarod Ramos");
        Console.WriteLine(mathAssignment1.GetSummary());
        Console.WriteLine(mathAssignment1.GetHomeWorkList());
        Console.WriteLine();

        WritingAssignment writingAssignment1 = new WritingAssignment("Hamlet", "English", "Shake Speare");
        Console.WriteLine(writingAssignment1.GetSummary());
        Console.WriteLine(writingAssignment1.GetWritingInformation());
        Console.WriteLine();

    }

}