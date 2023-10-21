public class MediumGoal : BudgetGoals
{

    private string _startDate;

    public MediumGoal(string name, decimal currentAmount, decimal targetAmount, string strategy, string targetDate, string startDate) : base(name, currentAmount, targetAmount, strategy, targetDate)
    {
        _startDate = startDate;
    }

    public override void DisplayGoal()
    {
        Console.WriteLine($"Medium Goal: \nName: {_name} \nStrategy:{_strategy} \nAmount: {_targetAmount} - {_currentAmount} \nDate: {_startDate} - {_targetDate}");
        Progress();
    }

    public override void Progress()
    {
        DateTime userTargetDate = DateTime.Parse(_targetDate);
        DateTime userStartDate = DateTime.Parse(_startDate);
        TimeSpan days = userTargetDate - userStartDate;
        _daysLeft = days.Days;

        _remainingAmount = _targetAmount -  _currentAmount;

        Console.WriteLine($"You have {_daysLeft} to save {_remainingAmount} to achieve {_name}.");
    }

}