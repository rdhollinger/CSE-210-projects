public class Reference
{
    private string _book;
    private string _chapter;
    private string _verse;
    private string _verse2;

    public Reference(string book, string chapter, string verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _verse2 = null;

    }

    public Reference(string book, string chapter, string verse, string verse2)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _verse2 = verse2;

    }

    public string toString()
    {
        string reference;
        if (_verse2 == null)
            reference = $"{_book} {_chapter}:{_verse}";
        else
            reference = $"{_book} {_chapter}:{_verse} - {_verse2}";
        return reference;
    }

}