
public class ManageGoals
{

    List<BudgetGoals> _goals = new List<BudgetGoals>();

    public void start()
    {

        Console.Clear();

        while (true)
        {

            Console.WriteLine("\nGoal Options:");
            Console.WriteLine(" 1: Create New Goal");
            Console.WriteLine(" 2: View Goal Information");
            Console.WriteLine(" 3: Complete Goal");
            Console.WriteLine(" 4: Go Back to Menu");
            Console.Write("Select a choice from the menu:");
            int userChoice = int.Parse(Console.ReadLine());

            if (userChoice == 1)
            {
                AddGoal();
            }

            else if (userChoice == 2)
            {
                DisplayList();
            }

            else if (userChoice == 3)
            {
                CompleteGoal();
            }

            else if (userChoice == 4)
            {
                break;
            }



        }
    }

    public void AddGoal()
    {

        Console.WriteLine("\nThe types of Goals are:");
        Console.WriteLine(" 1: Short Term Goal");
        Console.WriteLine(" 2: Medium Term Goal");
        Console.WriteLine(" 3: Long Term Goal");
        Console.Write("Which type of goal would you like to create?");
        int userChoice = int.Parse(Console.ReadLine());
        Console.WriteLine();

        if (userChoice == 1)
        {
            Console.WriteLine("Enter the name of goal: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your current savings: ");
            decimal currentAmount = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter the amount needed to be saved: ");
            decimal targetAmount = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter the strategy to achieve the goal: ");
            string strategy = Console.ReadLine();
            Console.WriteLine("Enter the target date to achieve the goal (yyyy-MM-dd): ");
            string targetDate = Console.ReadLine();

            ShortGoal newGoal = new ShortGoal(name, currentAmount, targetAmount, strategy, targetDate);
            _goals.Add(newGoal);

        }

        else if (userChoice == 2)
        {
            Console.WriteLine("Enter the name of goal: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your current savings: ");
            decimal currentAmount = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter the amount needed to be saved: ");
            decimal targetAmount = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter the strategy to achieve the goal: ");
            string strategy = Console.ReadLine();
            Console.WriteLine("Enter the start date to achieve the goal (yyyy-MM-dd): ");
            string startDate = Console.ReadLine();
            Console.WriteLine("Enter the target date to begin the goal (yyyy-MM-dd): ");
            string targetDate = Console.ReadLine();

            MediumGoal newGoal = new MediumGoal(name, currentAmount, targetAmount, strategy, targetDate, startDate);
            _goals.Add(newGoal);

        }

        else if (userChoice == 3)
        {
            Console.WriteLine("Enter the name of goal: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your current savings: ");
            decimal currentAmount = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter the amount needed to be saved: ");
            decimal targetAmount = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter the strategy to achieve the goal: ");
            string strategy = Console.ReadLine();
            Console.WriteLine("Enter the start date to achieve the goal (yyyy-MM-dd): ");
            string startDate = Console.ReadLine();
            Console.WriteLine("Enter the target date to begin the goal (yyyy-MM-dd): ");
            string targetDate = Console.ReadLine();

            LongGoal newGoal = new LongGoal(name, currentAmount, targetAmount, strategy, targetDate, startDate);
            _goals.Add(newGoal);

        }

    }

    public void DisplayList()
    {
        Console.WriteLine("Goal List:");
        for (int i = 0; i < _goals.Count; i++)
        {
            BudgetGoals goals = _goals[i];
            Console.Write($"{i + 1}. ");
            goals.DisplayGoal();
        }
    }

    public void CompleteGoal()
    {

        Console.WriteLine("Goal List:");
        for (int i = 0; i < _goals.Count; i++)
        {
            BudgetGoals goals = _goals[i];
            string name = goals.GetName();
            Console.WriteLine($"{i + 1}. {name}");
        }

        Console.Write("Enter the number of the goal you accomplished today: ");
        int userChoice = int.Parse(Console.ReadLine());
        BudgetGoals completeGoal = _goals[userChoice - 1];

        completeGoal.CompleteGoal();

        if (completeGoal.IsComplete() == true)
        {
            _goals.Remove(completeGoal);
        }
    }
}