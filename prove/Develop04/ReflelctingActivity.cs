public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questons = new List<string>();

    public ReflectingActivity()
    {

        _name = "Reflecting Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life";

    }

    public void Run()
    {

        Console.Clear();

        Console.WriteLine("Get Ready...");
        ShowSpinner();
        Console.WriteLine("\n");

        Console.WriteLine("Consider the following prompt:\n");
        DisplayPrompt();

        Console.WriteLine("\nWhen you have something in mind press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions.");
        Console.Write("You may begin in:");
        ShowCountDown();

        Console.Clear();





        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {

            DisplayQuestions();
        }

    }

    public string GetRandomPrompt()
    {

        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");

        Random randomPrompt = new Random();
        int index = randomPrompt.Next(_prompts.Count);

        return _prompts[index];

    }


public string GetRandomQuestion()
    {

        _questons.Add("Why was this experience meaningful to you?");
        _questons.Add("Have you ever done anything like this before?");
        _questons.Add("How did you get started?");
        _questons.Add("How did you feel when it was complete?");
        _questons.Add("What made this time different than other times when you were not as successful?");
        _questons.Add("What is your favorite thing about this experience?");
        _questons.Add("What could you learn from this experience that applies to other situations?");
        _questons.Add("What did you learn about yourself through this experience?");
        _questons.Add("How can you keep this experience in mind in the future?");

        Random randomQuestion = new Random();
        int index = randomQuestion.Next(_questons.Count);

        return _questons[index];

    }


public void DisplayPrompt()
    {

        string prompt = GetRandomPrompt();
        Console.WriteLine($"--- {prompt} ---");

    }

public void DisplayQuestions()
    {
        string question = GetRandomQuestion();
        Console.Write($"> {question}");
        ShowSpinner();
        Console.WriteLine();
    }
}