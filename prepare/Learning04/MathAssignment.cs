public class MathAssignment : Assignment
{
    private string _textbookSection = "";
    private string _problems = "";

    public string getTextbookSection()
    {
        return _textbookSection;
    }
    public void setTextbookSection(string textbooksection)
    {
        _textbookSection = textbooksection;
    }
    public string getProblems()
    {
        return _problems;
    }
    public void setProblems(string problems)
    {
        _problems = problems;
    }
    public string getHomeworkList()
    {
       return $"Section {_textbookSection} Problems {_problems}";
    }
}