
public class Income
{
    private string _name;
    private decimal _amountRecived;
    private DateOnly _dateRecived;
    private string _source;

    public Income(string name, decimal amountRecived, DateOnly dateRecived, string source)
    {
        _name = name;
        _amountRecived = amountRecived;
        _dateRecived = dateRecived;
        _source = source;

    }

    public void DisplayIncome()
    {
        Console.WriteLine($"Income: {_name} - {_source} - {_amountRecived} - {_dateRecived}");
    }

    public string GetStringRepresentation()
    {
        return $"Income: {_name} - {_source} - {_amountRecived} - {_dateRecived}";
    }

}