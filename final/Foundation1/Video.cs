public class Video
{
    private string _title;
    private string _author;
    private int _length;
    public List<Comment> comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void videoInfo()
    {
        Console.WriteLine($"{_title}: {_author}");
        Console.WriteLine($"Video length: {_length} minutes");
        foreach(Comment comment in comments)
        {
            comment.commentInfo();
        }
    }
    
}