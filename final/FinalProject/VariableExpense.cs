public class VariableExpense : Expense
{

    public VariableExpense(string category, decimal amount, decimal addedAmount) :base(category, amount, addedAmount)
    {
        
    }
    public override string GetStringRepresentationAdddedExpense()
    {
        return $"Variable Expense,{_category},{_amount},{0}";
    }

    public override string GetStringRepresentationRecordExpense()
    {
        return $"Variable Expense,{_category},{0},{_addedAmount}";
    }
    
    public override void PrintDetails()
    {
        Console.WriteLine($"Variable Expense: {_category} : {_amount}");
    }

}