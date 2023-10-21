

using System.Diagnostics;

public class Budget
{
    private List<BudgetGoals> _goals = new List<BudgetGoals>();

    public void start()
    {

        while(true)
        {
            Console.WriteLine("\nMenu Options");
            Console.WriteLine(" 1: Manage Budget");
            Console.WriteLine(" 2: Savings Goals");
            Console.WriteLine(" 3: Quit");
            Console.Write("Select a choice from the menu:");
            int userChoice = int.Parse(Console.ReadLine());

            if (userChoice == 1)
            {
                ManageBudget budget = new ManageBudget();
                budget.start();
            }

            else if (userChoice == 2)
            {
                ManageGoals goals = new ManageGoals();
                goals.start();
            }

            else if (userChoice == 3)
            {
                break;
            }

            
        }

    }

    



}