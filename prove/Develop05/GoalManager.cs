using System.Security.Cryptography.X509Certificates;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    private string userName;
    private List<string> _character = new List<string>();

    private bool _used = false;

    

    public void Start()
    {

        Console.WriteLine("\nHello and welcome to the Goal achiever!");
        Console.Write("Please enter your name here: ");
        userName = Console.ReadLine();

        Console.WriteLine("\nThis goal tracking activity will help you find ways to enjoy your goals and make it worth your while when you accomplish them.");
        Console.WriteLine("Each time you keep a goal you will be assigned points to your user. When you reach a certain mark you will be rewarded by leveling.");
        Console.WriteLine("Each time you level up you will be able to add features to your warrior.");
        Console.WriteLine("The higher the rank the greater the warrior.");


        while(true)
        {

            DipslayPlayerInfo();
            PointAnimation();

            Console.WriteLine("\nMenu Options");
            Console.WriteLine(" 1: Create New Goal");
            Console.WriteLine(" 2: List Goals");
            Console.WriteLine(" 3: Save Goals");
            Console.WriteLine(" 4: Load Goals");
            Console.WriteLine(" 5: Record Event");
            Console.WriteLine(" 6: View Character");
            Console.WriteLine(" 7: Quit");
            Console.Write("Select a choice from the menu:");
            int userChoice = int.Parse(Console.ReadLine());

            if (userChoice == 1)
            {
                CreateGoal();
            }
            
            else if (userChoice ==2)
            {
                ListGoalDetails();
            }

            else if (userChoice ==3)
            {
                Console.WriteLine("What is the filename for the goal file?");
                string file = Console.ReadLine();
                SaveGoals(file);
            }

            else if (userChoice ==4)
            {

                Console.WriteLine("What is the filename? ");
                string file = Console.ReadLine();
                LoadGoals(file);
                
            }

            else if (userChoice ==5)
            {
                RecordEvent();
            }

            else if (userChoice ==6)
            {
                foreach(string attribute in _character)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine(attribute);
                }
            }

            else if (userChoice ==7)
            {
                break;
            }

            else 
            {

                Console.WriteLine("You have chosen an incorrect option, try again.");

            }
        }



    }

    public void DipslayPlayerInfo()
    {
        Console.WriteLine($"\n{userName} your score is: {_score}");
        
    }

    public void ListGoalNames()
    {
        Console.WriteLine("The goals are:");


    }

    public void ListGoalDetails()
    {
        Console.WriteLine("\nThe goals are:");

                for (int i = 0; i < _goals.Count; i++)
                {
                    Goal goal = _goals[i];
                    Console.Write($"{i + 1}. ");
                    goal.GetDetailsString();
                }
    }

    public void CreateGoal()
    {
        Console.WriteLine("\nThe types of Goals are:");
                Console.WriteLine(" 1: Simple Goal");
                Console.WriteLine(" 2: Eternal Goal");
                Console.WriteLine(" 3: Checklist Goal");
                Console.Write("Which type of goal would you like to create?");
                int userChoice2 = int.Parse(Console.ReadLine());

                if (userChoice2 == 1)
                {
                    Console.Write("What is the name of your goal:");
                    string shortName = Console.ReadLine();
                    Console.Write("What is a short description of it?");
                    string description = Console.ReadLine();
                    Console.Write("What is the amount of points associated with this goal?");
                    int points = int.Parse(Console.ReadLine());

                    SimpleGoal newSimpleGoal = new SimpleGoal(shortName, description, points);
                    _goals.Add(newSimpleGoal);
                }

                else if (userChoice2 == 2)
                {

                    Console.Write("What is the name of your goal:");
                    string shortName = Console.ReadLine();
                    Console.Write("What is a short description of it?");
                    string description = Console.ReadLine();
                    Console.Write("What is the amount of points associated with this goal?");
                    int points = int.Parse(Console.ReadLine());

                    EternalGoal newEternalGoal = new EternalGoal(shortName, description, points);
                    _goals.Add(newEternalGoal);

                }

                else if (userChoice2 == 3)
                {

                    Console.Write("What is the name of your goal:");
                    string shortName = Console.ReadLine();
                    Console.Write("What is a short description of it?");
                    string description = Console.ReadLine();
                    Console.Write("What is the amount of points associated with this goal? ");
                    int points = int.Parse(Console.ReadLine());
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    int amount = int.Parse(Console.ReadLine());
                    Console.Write("What is the bonus for accomploshing it that many times? ");
                    int bonus = int.Parse(Console.ReadLine());

                    CheckListGoal newCheckListGoal =  new CheckListGoal(shortName, description, points, amount, bonus);
                    _goals.Add(newCheckListGoal);
                }

    }
    

    public void RecordEvent()
    {
        Console.WriteLine("\nThe goals are:");

        for (int i = 0; i < _goals.Count; i++)
        {
            Goal goal = _goals[i];
            string name = goal.GetName();
            Console.WriteLine($"{i + 1}. {name}");
        }

        Console.Write("Enter the number of the goal you accomplished today: ");
        int userChoice3 = int.Parse(Console.ReadLine());
        Goal accomplsihedGoal = _goals[userChoice3 - 1];

        accomplsihedGoal.RecordEvent();
        _score += accomplsihedGoal.GetPoints();

        Console.WriteLine($"Congratulations you have a total score of {_score} points!");
    
    }

    public void SaveGoals(string file)
    {

        Console.WriteLine("Saving file ....\n");
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals(string file)
    {

        Console.WriteLine("Reading File ......\n");
        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            
            string goalName = parts[0].Trim();
            string shortname =  parts[1].Trim();
            string description = parts[2].Trim();
            int points = int.Parse(parts[3]);

            if (goalName == "Simple Goal")
            {

                SimpleGoal newGoal = new SimpleGoal(shortname, description, points);
                _goals.Add(newGoal);

            }

            else if (goalName == "Checklist Goal")
            {

                int bonus = int.Parse(parts[4]);
                int target = int.Parse(parts[5]);

                CheckListGoal newGoal = new CheckListGoal(shortname, description, points, bonus, target);
                _goals.Add(newGoal);
  
            }

            else
            {

                EternalGoal newGoal = new EternalGoal(shortname, description, points);
                _goals.Add(newGoal);

            }
            
        }
    }

    public void PointAnimation()
    {
        if (_score <= 50 )
        {

            int currentScore = 50 - _score;
            Console.Write($"You still need {currentScore} to get your first achievemant.\n");
        }

        else if (_score >= 50 && _used == false)
        {

            _used = true;

            Console.WriteLine("Congratulations you have achieved level 1 you get to choose your character:");
            Console.WriteLine("1. Elf");
            Console.WriteLine("2. Mage");
            Console.WriteLine("3. Ork");
            Console.WriteLine("4. Viking");
            Console.WriteLine("5. Human");
            Console.WriteLine("Choose your character");
            string character = Console.ReadLine();
            Console.WriteLine();

            _character.Add($"Level 1: {character}");

        }

        else if (_score <= 100 && _used == true)
        {
            int currentScore = 100 - _score;
            Console.Write($"You still need {currentScore} to get your first achievemant.\n");
        }

        else if (_score >= 100 && _used == false)
        {

            Console.WriteLine("Congratulations you have achieved level 2 you get to choose your Primary Weapon:");
            Console.WriteLine("1. Sword");
            Console.WriteLine("2. Bow");
            Console.WriteLine("3. Axe");
            Console.WriteLine("4. Spear");
            Console.WriteLine("Choose your Weapon");
            string character = Console.ReadLine();
            Console.WriteLine();

            _character.Add($"Level 2: {character}");

        }

        else if (_score <= 300  && _used == true)
        {
            int currentScore = 300 - _score;
            Console.Write($"You still need {currentScore} to get your first achievemant.\n");
        }

        else if (_score >= 300 && _used == false)
        {

            Console.WriteLine("Congratulations you have achieved level 3 you get to choose your Character Type:");
            Console.WriteLine("1. Ranger");
            Console.WriteLine("2. Assasin");
            Console.WriteLine("3. Spy");
            Console.WriteLine("4. Knight");
            Console.WriteLine("Choose your Character Type");
            string character = Console.ReadLine();
            Console.WriteLine();

            _character.Add($"Level 3: {character}");

        }

        else if (_score <= 500 && _used == true)
        {
            int currentScore = 500 - _score;
            Console.Write($"You still need {currentScore} to get your first achievemant.\n");
        }

        else if (_score >= 500 && _used == false)
        {

            Console.WriteLine("Congratulations you have achieved level 4 you get to choose your Animal:");
            Console.WriteLine("1. Horse");
            Console.WriteLine("2. Camel");
            Console.WriteLine("3. Dragon");
            Console.WriteLine("4. Bear");
            Console.WriteLine("Choose your Animal");
            string character = Console.ReadLine();
            Console.WriteLine();

            _character.Add($"Level 4: {character}");

        }

        else 
        {
            Console.WriteLine("Stay tuned to further better your character.");
        }
    }
}