public class Comment
{
    private string _comment;
    private string _author;


public Comment(string author, string comment)
{
    _author = author;
    _comment = comment;
}
    public void commentInfo()
    {
        Console.WriteLine($"{_author}: {_comment}");
    }
}