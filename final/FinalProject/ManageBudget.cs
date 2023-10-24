public class ManageBudget
{

    private List<Income> _income = new List<Income>();
    private List<Expense> _expense = new List<Expense>();
    private List<Expense> _addedExpense = new List<Expense>();


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
            Console.WriteLine(" 5: Go Back to Menu");
            Console.Write("Select a choice from the budget menu:");
            int budgetChoice = int.Parse(Console.ReadLine());

            if (budgetChoice == 1)
            {
                Console.Write("\nEnter name of person who recieved an income: ");
                string name = Console.ReadLine();
                Console.Write("What source did you recieve your income from: ");
                string source = Console.ReadLine();
                Console.Write("Enter the amount recieved after Tax: ");
                decimal amountRecived = decimal.Parse(Console.ReadLine());
                Console.Write("Enter date income was recieved (yyyy-MM-dd): ");
                string dateRecieved = Console.ReadLine();

                _totalIncome += amountRecived;

                Income newIncome = new Income(name, amountRecived, dateRecieved, source);
                _income.Add(newIncome);
            }


            else if (budgetChoice == 2)
            {

                while(true)
                {

                    Console.WriteLine("\nSelect Type:");
                    Console.WriteLine(" 1: Variable");
                    Console.WriteLine(" 2: Fixed");
                    Console.WriteLine(" 3: Exit");
                    Console.Write("Enter the type of expense or '3' to go back to Budget Options: ");
                    int userOption = int.Parse(Console.ReadLine());

                    if (userOption == 1)
                    {

                        string category = GetCategoryExpense();
                        decimal amount = GetAmountExpense();

                        _expectedExepense += amount;

                        VariableExpense newExpense = new VariableExpense(category, amount);

                        _expense.Add(newExpense);

                    }

                    else if (userOption == 2)
                    {
                        string category = GetCategoryExpense();
                        decimal amount = GetAmountExpense();

                        FixedExpense newExpense = new FixedExpense(category, amount);

                        _expense.Add(newExpense);

                        _expectedExepense += amount;

                    }

                    else if (userOption == 3)
                    {
                        break;
                    }

                    else
                    {
                        Console.WriteLine("You have chosen an incorrect option, Please reselect.");
                    }

                }

            }

            else if (budgetChoice == 3)
            {


            }

            else if (budgetChoice == 4)
            {
                DisplayIncome();

                DisplayExpense();

                _savings = _totalIncome  - _expectedExepense;
                Console.WriteLine($"\nYou will save: {_savings}");
            }

            else if (budgetChoice == 5)
            {
                break;
            }
        }

    }

    // Getting Variable Methods to call the fixed and variable expense class

    public string GetCategoryExpense()
    {
        Console.Write("Enter the expense category: ");
        string category = Console.ReadLine();

        return category;
    }

    public decimal GetAmountExpense()
    {
        Console.Write("Enter the allocated amount: ");
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
        for (int i = 0; i < _expense.Count; i++)
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


    // Add Expense Methof
    public void AddExpense()
    {
        Console.WriteLine("Category Menu: ");
        for (int i = 0; i < _expense.Count; i++)
        {
            Expense expense = _expense[i];
            string category = expense.GetCategory();
            Console.WriteLine($"{i + 1}: {category}");
        }

        Console.Write("Choose a category for the added expense: ");
        int categoryChoice = int.Parse(Console.ReadLine());
        Expense addedExpense = _expense[categoryChoice - 1];

        


    }
    

}