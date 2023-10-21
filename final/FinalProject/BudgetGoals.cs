

public abstract class BudgetGoals
{
    protected string _name;
    protected decimal _currentAmount;
    protected decimal _targetAmount;
    protected string _strategy;
    protected string _targetDate;
    protected int _daysLeft;
    protected decimal _remainingAmount;
    protected bool _isComplete;

    public BudgetGoals(string name, decimal currentAmount, decimal targetAmount, string strategy, string targetDate)
    {
        _name = name;
        _currentAmount = currentAmount;
        _targetAmount = targetAmount;
        _strategy = strategy;
        _targetDate = targetDate;
        _isComplete = false;

    }

    public virtual void Progress()
    {
        DateTime userDate = DateTime.Parse(_targetDate);
        DateTime currentDate = DateTime.Now;
        TimeSpan days = userDate - currentDate;
        _daysLeft = days.Days;

        _remainingAmount = _targetAmount -  _currentAmount;

        if (_targetAmount == _currentAmount)
        {
            Console.WriteLine("You have reached your target amount, Congratulations!!");
        }

        else
        {
            Console.WriteLine($"You have {_daysLeft} days to save {_remainingAmount} to achieve your goal.");
        }

        
    }

    public virtual void DisplayGoal()
    {
        Console.WriteLine($"Short Goal: \nName: {_name} \nStrategy: {_strategy} \nCurrent Amount/Target Amount: {_currentAmount} - {_targetAmount} \nDate: ({_targetDate})");

        Progress();
    }

    public virtual void CompleteGoal()
    {
        _isComplete = true;
        Console.WriteLine("Congratulations you have achieved your goal.");
    }

    public virtual bool IsComplete()
    {
        return _isComplete;
    }

    public string GetName()
    {
        return$"{_name}";
    }

}