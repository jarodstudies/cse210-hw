
public abstract class Expense
{

    protected decimal _addedAmount;
    protected string _category;
    protected decimal _amount;

    public Expense(string category, decimal amount, decimal addedAmount)
    {
        _category = category;
        _amount = amount;
        _addedAmount = addedAmount;
    }

    public void AddExpense()
    {
        Console.WriteLine($"You have added {_addedAmount} to the following Category: {_category}.");
    }

    public abstract string GetStringRepresentationAdddedExpense();

    public abstract string GetStringRepresentationRecordExpense();
    

    public abstract void PrintDetails();

    public void SetAddedAmount(decimal addedAmount)
    {
        _addedAmount = addedAmount;
    }

    public decimal GetAddedAmount()
    {
        return _addedAmount;
    }

    public string GetCategory()
    {
        return _category;
    }

}