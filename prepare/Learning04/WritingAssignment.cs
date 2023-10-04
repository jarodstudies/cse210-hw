public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string title, string topic, string studentName) : base(topic, studentName)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {

        string studentName =  GetStudentName();
        return $"{_title} by {studentName}";
    }
}