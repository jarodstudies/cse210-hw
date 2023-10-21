
public abstract class Expense
{

    protected string _category;
    protected decimal _amount;
    protected decimal _addedAmount;

    public Expense(string category, decimal amount)
    {
        _category = category;
        _amount = amount;

    }

    public abstract void PrintDetails();

    public abstract string GetStringRepresentation();

}