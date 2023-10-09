using System.Diagnostics;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity()
    {
        
    }

    public void DisplayStartingMessage()
    {

        Console.Clear();

        Console.WriteLine($"\nWelcome to the {_name}.\n");
        Console.WriteLine(_description);

        Console.Write("How long in seconds, would you like for your session: ");
        _duration = int.Parse(Console.ReadLine());
    }

    public void DisplayEndingMessage()
    {

        Console.WriteLine("\nWell Done!");
        ShowSpinner();

    }

    public void ShowSpinner()
    {

        List<string> animation = new List<string>();
        animation.Add("|");
        animation.Add("/");
        animation.Add("-");
        animation.Add("\\");
        animation.Add("|");
        animation.Add("/");
        animation.Add("-");
        animation.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(8);

        int i = 0;

        while (DateTime.Now < endTime)
        {

            string anime = animation[i];

            Console.Write(anime);
            Thread.Sleep(800);
            Console.Write("\b \b");

            i++;

            if (i >= animation.Count)
            {

                i = 0;
            }
            
        }

    }

    public void ShowCountDown()
    {


        for (int i = 5 ; i > 0; i--)
        {

            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

    }

    public int GetDuration()
    {
        return _duration;
    }

}