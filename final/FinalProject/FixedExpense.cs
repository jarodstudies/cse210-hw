public class FixedExpense : Expense
{

    public FixedExpense(string category, decimal amount,decimal addedAmount) :base(category, amount, addedAmount)
    {
        
    }

    public override string GetStringRepresentationAdddedExpense()
    {
        return $"Fixed Expense,{_category},{_amount},{0}";
    }

    public override string GetStringRepresentationRecordExpense()
    {
        return $"Fixed Expense,{_category},{0},{_addedAmount}";
    }
    
    public override void PrintDetails()
    {
        Console.WriteLine($"Fixed Expense: {_category} : {_amount}");
    }

}