public class EternalGoal : Goal 
{

    private bool _isComplete;

    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {


        _isComplete = true;
        Console.WriteLine($"Congratulations you hav earned {_points}");
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"Eternal Goal, {_shortName}, {_description}, {_points}";
    }

    
}