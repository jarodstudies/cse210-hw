public class ManageBudget
{

    private List<Income> _income = new List<Income>();
    private List<Expense> _expense = new List<Expense>();

    private decimal _savings;
    private decimal _totalIncome;
    private decimal _expectedExepense;


    // Start the Budget Plan
    public void start()
    {

        Console.Clear();

        while(true)
        {

            Console.WriteLine("\nBudget Options:");
            Console.WriteLine(" 1: Add Income");
            Console.WriteLine(" 2: Add Expense");
            Console.WriteLine(" 3: Record Expense");
            Console.WriteLine(" 4: View Budget Plan");
            Console.WriteLine(" 5: View Savings");
            Console.WriteLine(" 6: Go Back to Menu");
            Console.Write("Select a choice from the budget menu:");
            int budgetChoice = int.Parse(Console.ReadLine());

            if (budgetChoice == 1)
            {
                Console.WriteLine("\nEnter name of person who recieved an income: ");
                string name = Console.ReadLine();
                Console.WriteLine("\nWhat source did you recieve your income from: ");
                string source = Console.ReadLine();
                Console.WriteLine("\nEnter the amount recieved after Tax: ");
                decimal amountRecived = decimal.Parse(Console.ReadLine());
                Console.WriteLine("\nEnter date income was recieved: ");
                DateOnly dateRecieved = DateOnly.Parse(Console.ReadLine());

                _totalIncome += amountRecived;

                Income newIncome = new Income(name, amountRecived, dateRecieved, source);
                _income.Add(newIncome);
            }


            else if (budgetChoice == 2)
            {

                Console.WriteLine("\nEnter the type of expense (Variable or Fixed): ");
                string expenseType = Console.ReadLine();

                if (expenseType == "Variable")
                {

                    string category = GetCategoryExpense();
                    decimal amount = GetAmountExpense();

                    _expectedExepense += amount;

                    VariableExpense newExpense = new VariableExpense(category, amount);

                    _expense.Add(newExpense);

                }

                else if (expenseType == "Fixed")
                {
                    string category = GetCategoryExpense();
                    decimal amount = GetAmountExpense();

                    FixedExpense newExpense = new FixedExpense(category, amount);

                    _expense.Add(newExpense);

                    _expectedExepense += amount;

                }

            }

            else if (budgetChoice == 3)
            {

            }

            else if (budgetChoice == 4)
            {
                DisplayIncome();

                DisplayExpense();
            }

            else if (budgetChoice == 5)
            {
                _savings = _totalIncome  - _expectedExepense;
                Console.WriteLine($"You will save: {_savings}");
            }

            else if (budgetChoice == 6)
            {
                break;
            }
        }

    }

    // Getting Variable Methods to call the fixed and variable expense class

    public string GetCategoryExpense()
    {
        Console.WriteLine("Enter the expense category: ");
        string category = Console.ReadLine();

        return category;
    }

    public decimal GetAmountExpense()
    {
        Console.WriteLine("Enter the allocated amount: ");
        decimal amount = int.Parse(Console.ReadLine());

        return amount;
    }


    // Displaying Mehtods
    public void DisplayIncome()
    {

        Console.WriteLine("\nIncome recieved:");

        for (int i = 0; i < _income.Count; i++)
        {
            Income income = _income[i];
            Console.Write($"{i + 1}. ");
            income.DisplayIncome();
        }

        Console.WriteLine($"Total Income: {_totalIncome}");
    }

    public void DisplayExpense()
    {

        Console.WriteLine("\nExptected Expense:");
        for (int i = 0; i < _income.Count; i++)
        {
            Expense expense = _expense[i];
            Console.Write($"{i + 1}. ");
            expense.PrintDetails();
        }

        Console.WriteLine($"The total amount of your expenses: {_expectedExepense}");

    }


    // Getting Varibales within the class
    public decimal GetSavings()
    {
        return _savings;
    }

    

}