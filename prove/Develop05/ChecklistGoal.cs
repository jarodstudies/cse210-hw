public class CheckListGoal : Goal 
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public CheckListGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _bonus = bonus;
        _target =target;
        _amountCompleted = 0;
    }

    public override void RecordEvent()
    {
        _amountCompleted += 1;
        
        if (_amountCompleted != _target)
        {
            Console.WriteLine($"Congratulations you have earned {_points} points.");
        }

        else 
        {
            Console.WriteLine($"Congratulations you have earned {_points} and a bonus of {_bonus} for completing the goal!");
            _points += _bonus;
        }
        
    }

    public override bool IsComplete()
    {
        return _amountCompleted == _target;
    }

    public override string GetStringRepresentation()
    {
        return $"Checklist Goal, {_shortName}, {_description}, {_points}, {_bonus}, {_amountCompleted}, {_target}";
    }

    public override void GetDetailsString()
    {

        if (IsComplete() == false)
        {

            Console.WriteLine($"[ ] {_shortName} ({_description}) --- Currently completed {_amountCompleted}/{_target}");
        }

        else
        {
            Console.WriteLine($"[X] {_shortName} ({_description}) --- Currently completed {_amountCompleted}/{_target}");
        }
        
    }


}