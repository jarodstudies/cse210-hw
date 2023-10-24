public class FixedExpense : Expense
{

    public FixedExpense(string category, decimal amount) :base(category, amount)
    {
        
    }
    
    public override void PrintDetails()
    {
        Console.WriteLine($"Fixed Expense: {_category} : {_amount}");
    }

    public override void AddExpense()
    {

        Console.WriteLine("");

    }

    public override string GetStringRepresentation()
    {
        throw new NotImplementedException();
    }

}