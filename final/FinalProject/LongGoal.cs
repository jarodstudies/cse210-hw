public class LongGoal : BudgetGoals
{

    private string _startDate;

    public LongGoal(string name, decimal currentAmount, decimal targetAmount, string strategy, string targetDate, string startDate) : base(name, currentAmount, targetAmount, strategy, targetDate)
    {
        _startDate = startDate;
    }

    public override void DisplayGoal()
    {
        Console.WriteLine($"Long Term Goal: \nName: {_name} \nStrategy: {_strategy} \nTarget Amount/Current Amount: {_targetAmount} - {_currentAmount} \nStart Date/Target Date: {_startDate} - {_targetDate}");

        Progress();
    }

    public override void Progress()
    {
        DateTime userTargetDate = DateTime.Parse(_targetDate);
        DateTime userStartDate = DateTime.Parse(_startDate);
        TimeSpan days = userTargetDate - userStartDate;
        _daysLeft = days.Days;

        _remainingAmount = _targetAmount -  _currentAmount;

        Console.WriteLine($"You have {_daysLeft} days to save {_remainingAmount} to achieve your goal.");
    }

}