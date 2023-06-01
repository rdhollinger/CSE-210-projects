public class WritingAssignment : Assignment
{
    public string _title = "";

    public string getTitle()
    {
        return _title;
    }
    public void setTitle(string title)
    {
        _title = title;
    }
    public string getWritingInformation()
    {
        return $"{_title} by {getStudentName()}";
    }
}