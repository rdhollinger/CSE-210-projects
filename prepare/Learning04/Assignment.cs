public class Assignment
{
    private string _studentName = "";
    private string _topic = "";

    public string getStudentName()
    {
        return _studentName;
    }
    public void setStudentName(string studentName)
    {
        _studentName = studentName;
    }
    public string getTopic()
    {
        return _topic;
    }
    public void setTopic(string topic)
    {
        _topic = topic;
    }


    public string getSummary()
    {
       return $"{_studentName} - {_topic}";
    }
}