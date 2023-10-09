public class ListeningActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>();

    private List<string> _userList =  new List<string>();

    public ListeningActivity()
    {

        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.\n";

    }

    public void Run()
    {

    Console.Clear();
    Console.WriteLine("Get ready...");
    ShowSpinner();

    Console.WriteLine("\nList as many responses you can to the following prompt.");

    GetRandomPrompt();

    Console.Write("\nYou may begin in: ");
    ShowCountDown();
    Console.WriteLine();

    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(_duration);

    _userList = new List<string>();

    while (DateTime.Now < endTime)
        {
            GetListFromUser();
        }

        _count = GetListFromUser().Count();
        Console.WriteLine($"You listed {_count} items!");
    }

    public void GetRandomPrompt()
    {

        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");

        Random randomPrompt = new Random();
        int index =  randomPrompt.Next(_prompts.Count);

        Console.WriteLine($"--- {_prompts[index]} ---");
    }

    public List<string> GetListFromUser()
    {
        
        Console.Write("<");
        string userEntry = Console.ReadLine();

        _userList.Add(userEntry);

        return _userList;
    }

}