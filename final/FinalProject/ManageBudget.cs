using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

public class ManageBudget
{

    private List<Income> _income = new List<Income>();
    private List<Expense> _expense = new List<Expense>();
    private List<Expense> _addedExpense = new List<Expense>();

    private decimal _savings;
    private decimal _currentSavings;
    private decimal _totalIncome;
    private decimal _expectedExepense;
    private decimal _totalExpense;


    // Start the Budget Plan
    public void start()
    {

        Console.Clear();

        while(true)
        {

            Console.WriteLine("\nBudget Options:");
            Console.WriteLine(" 1: Add Income");
            Console.WriteLine(" 2: Add Expense");
            Console.WriteLine(" 3: Add Current Savings");
            Console.WriteLine(" 4: Record Expense");
            Console.WriteLine(" 5: View Budget Plan");
            Console.WriteLine(" 6: Save Budget");
            Console.WriteLine(" 7: Load Budget");          
            Console.WriteLine(" 8: Go Back to Menu");
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

                        VariableExpense newExpense = new VariableExpense(category, amount, 0);

                        _expense.Add(newExpense);

                    }

                    else if (userOption == 2)
                    {
                        string category = GetCategoryExpense();
                        decimal amount = GetAmountExpense();

                        FixedExpense newExpense = new FixedExpense(category, amount, 0);

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
                Console.WriteLine("Enter your current savings amount: ");
                _currentSavings = decimal.Parse(Console.ReadLine());
            }

            else if (budgetChoice == 4)
            {
                AddExpense();
            }

            else if (budgetChoice == 5)
            {
                DisplayIncome();

                if (_expense.Count == 0)
                {
                    Console.WriteLine("\nYou have not added any expense yet.");
                }
                
                else if (_expense.Count > 0)
                {

                    DisplayExpense();
                    _savings = _totalIncome  - _expectedExepense;
                    Console.WriteLine($"\nYou will save: {_savings}");

                }

                if (_addedExpense.Count == 0)
                {
                    Console.WriteLine("\nYou have not recorded any expense yet.");
                }

                else if (_addedExpense.Count > 0)
                {
                    DisplayAddedExpense();

                    _savings = _totalIncome  - _totalExpense;
                    Console.WriteLine($"\nYou are currently saving: {_savings}");

                    _currentSavings +=  _savings;
                    Console.WriteLine($"You currently have {_currentSavings} in your savings account.");
                }
            }

            else if (budgetChoice == 6)
            {
                Console.WriteLine("Enter file name to save the data:");
                string fileName = Console.ReadLine();
                SaveBudgetData(fileName);
            }

            else if (budgetChoice == 7)
            {
                Console.WriteLine("Enter file name to load the data:");
                string fileName = Console.ReadLine();
                LoadBudgetData(fileName);
            }

            else if (budgetChoice == 8)
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

    public decimal GetAddedAmount()
    {
        Console.Write("Enter the amount paid: ");
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

    public void DisplayAddedExpense()
    {

        Console.WriteLine("\nAdded Expense:");
        for (int i = 0; i < _addedExpense.Count; i++)
        {
            Expense addedExpense = _addedExpense[i];
            Console.Write($"{i + 1}. ");
            addedExpense.AddExpense();
        }

        Console.WriteLine($"The total amount of your current expenses: {_totalExpense}");

    }



    // Getting Varibales within the class
    public decimal GetSavings()
    {
        return _savings;
    }


    // Add Expense Methof
    public void AddExpense()
    {

        Console.WriteLine(" Exepense Type: ");
        Console.WriteLine(" 1: Variable");
        Console.WriteLine(" 2: Fixed");
        Console.Write("Choose the type for the added expense: ");
        int userOption = int.Parse(Console.ReadLine());

        if (userOption == 1)
        {
            string category = GetCategoryExpense();
            decimal addedAmount = GetAddedAmount();

            _totalExpense += addedAmount;

            VariableExpense newExpense = new VariableExpense(category, 0, addedAmount);
            _addedExpense.Add(newExpense);
            newExpense.AddExpense();
        }

        else if (userOption == 2)
        {
            string category = GetCategoryExpense();
            decimal addedAmount = GetAddedAmount();

            _totalExpense += addedAmount;

            FixedExpense newExpense = new FixedExpense(category, 0, addedAmount);
            _addedExpense.Add(newExpense);
            newExpense.AddExpense();
        }


    }

    public void SaveBudgetData(string fileName)
    {
            using (StreamWriter writer = new StreamWriter(fileName))
        {
            // Save the income data
            foreach (Income income in _income)
            {
                writer.WriteLine($"{income.GetStringRepresentation()}");
            }
            // Save the expected expenses
            foreach (Expense expense in _expense)
            {
                writer.WriteLine($"Expense,{expense.GetStringRepresentationAdddedExpense()}");
            }
            // Save the recorded expenses
            foreach (Expense addedExpense in _addedExpense)
            {
                writer.WriteLine($"Expense,{addedExpense.GetStringRepresentationRecordExpense()}");
            }
            // Save current savings and total expenses
            writer.WriteLine($"CurrentSavings,{_currentSavings}");
            writer.WriteLine($"TotalIncome,{_totalIncome}");
            writer.WriteLine($"TotalExpectedExpenses,{_expectedExepense}");
            writer.WriteLine($"TotalRecordedExpenses,{_totalExpense}");
        }
        Console.WriteLine("Budget data has been successfully saved to the file.");
    }

    public void LoadBudgetData(string fileName)
    {
        using (StreamReader reader = new StreamReader(fileName))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split(',');
                if (parts.Length >= 1)
                {
                    if (parts[0] == "Income" && parts.Length == 5)
                    {
                        string name = parts[1];
                        string source = parts[2];
                        decimal amount = decimal.Parse(parts[3]);
                        string dateReceived = parts[4];
                        Income newIncome = new Income(name, amount, dateReceived, source);
                        _income.Add(newIncome);
                    }
                    else if (parts[0] == "Expense" && parts.Length == 5)
                    {
                        string expenseType = parts[1];
                        string category = parts[2];
                        decimal amount = decimal.Parse(parts[3]);
                        decimal recordedAmount = decimal.Parse(parts[4]);

                        if (expenseType == "Variable Expense")
                        {
                            VariableExpense newExpense = new VariableExpense(category, amount, recordedAmount);
                            _expense.Add(newExpense);
                            _expectedExepense += amount;
                        }
                        else if (expenseType == "Fixed Expense")
                        {
                            FixedExpense newExpense = new FixedExpense(category, amount, recordedAmount);
                            _addedExpense.Add(newExpense);
                            _totalExpense += recordedAmount;
                        }
                    }
                    else if (parts[0] == "CurrentSavings" && parts.Length == 2)
                    {
                        _currentSavings = decimal.Parse(parts[1]);
                    }
                    else if (parts[0] == "TotalIncome" && parts.Length == 2)
                    {
                        _totalIncome = decimal.Parse(parts[1]);
                    }
                    else if (parts[0] == "TotalExpectedExpenses" && parts.Length == 2)
                    {
                        _expectedExepense = decimal.Parse(parts[1]);
                    }
                    else if (parts[0] == "TotalRecordedExpenses" && parts.Length == 2)
                    {
                        _totalExpense = decimal.Parse(parts[1]);
                    }
                }
            }
            Console.WriteLine("Budget data has been successfully loaded from the file.");
        }
    }
}
    