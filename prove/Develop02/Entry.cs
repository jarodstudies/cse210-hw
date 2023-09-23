public class Entry 
{

    public string _date;
    public string _promptText;
    public string _entryText;
    public void Dipslay()
    {
        Console.WriteLine($"\nDate: {_date} - Prompt: {_promptText}");
        Console.WriteLine($"{_entryText}\n"); 
    }


}