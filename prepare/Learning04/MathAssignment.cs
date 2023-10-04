public class MathAssignment : Assignment
{
    private string _textBookSection;
    private string _problems;

    public MathAssignment (string textBookSection, string problems, string topic, string studentName) : base(topic , studentName )
    {

        _textBookSection = textBookSection;
        _problems =  problems;

    }
    public string GetHomeWorkList()
    {
        return $"Section {_textBookSection} - Problems {_problems}";
    }
}