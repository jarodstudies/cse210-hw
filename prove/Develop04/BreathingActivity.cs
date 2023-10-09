using System;
using System.Runtime.InteropServices;


public class BreathingActivity : Activity
{

    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.\n";

    }

    public void Run()
    {

        Console.Clear();

        Console.WriteLine("Get Ready...");
        ShowSpinner();
        Console.WriteLine("\n");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {

            Console.Write("Breathe in...");
            ShowCountDown();
            Console.WriteLine();
            Console.Write("Now breathe out...");
            ShowCountDown();
            Console.WriteLine("\n");
        }
        
    }

}