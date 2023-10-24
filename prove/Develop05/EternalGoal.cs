public class EternalGoal : Goal 
{

    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {

    }

    public override void RecordEvent()
    {
        Console.WriteLine($"Congratulations you hav earned {_points}");
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"Eternal Goal, {_shortName}, {_description}, {_points}";
    }

    
}