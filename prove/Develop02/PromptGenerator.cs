public class PromptGenerator{

    public List<string> _prompts;

    public string GetRandomPrompt()
    {

        _prompts = new List<string>();

        _prompts.Add("Who was the most interesting person I interacted with today?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("List the 3 things you are grateful for today and why?");
        _prompts.Add("What went well today?");
        _prompts.Add("Who do you wish you had talked to today? What would you say?");
        _prompts.Add("What is one thing you want to remember from today?");
        _prompts.Add("What negative emotions am I holding onto? How can I let them go?");

        Random randomGenerator =  new Random();
        int index = randomGenerator.Next(_prompts.Count);

        //Console.WriteLine(_prompts[index]);

        return _prompts[index];
    }

}