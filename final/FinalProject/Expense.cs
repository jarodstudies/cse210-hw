
public abstract class Expense
{

    protected decimal _addedAmount;
    protected string _category;
    protected decimal _amount;

    public Expense(string category, decimal amount)
    {
        _category = category;
        _amount = amount;
        

    }

    public abstract void AddExpense();

    public abstract void PrintDetails();

    public abstract string GetStringRepresentation();

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