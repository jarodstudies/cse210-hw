public class VariableExpense : Expense
{

    public VariableExpense(string category, decimal amount) :base(category, amount)
    {
        
    }
    
    public override void PrintDetails()
    {
        Console.WriteLine($"Variable Expense: {_category} : {_amount}");
    }

    public override string GetStringRepresentation()
    {
        throw new NotImplementedException();
    }

}