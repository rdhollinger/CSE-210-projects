public class Scripture
{
    private List<Word> _words = new List<Word>();
    private Reference reference;
    private Random _random = new Random();
    private List<int> _generatedNumbers = new List<int>();

    public Scripture(string scripture, string book, string chapter, string verse)
    {

        string[] words = scripture.Split();
        foreach (string word in words)
        {
            Word wordObj = new Word(word);
            _words.Add(wordObj);
        }
        reference = new Reference(book, chapter, verse);
    }

    public Scripture(string scripture, string book, string chapter, string verse, string verse2)
    {

        string[] words = scripture.Split();
        foreach (string word in words)
        {
            Word wordObj = new Word(word);
            _words.Add(wordObj);
        }
        reference = new Reference(book, chapter, verse, verse2);
        
    }

    public void HideWords()
    {

        int index;
        for (int i = 0; i < 3; i++)
        {
            do
            {
                index = _random.Next(_words.Count);
            }
            while (_generatedNumbers.Contains(index));

            _generatedNumbers.Add(index);
            _words[index].HideWord();
        }

        // int random;
        // //random = _random.Next(0,_words.Count); 
        // do{  
        //     random = _random.Next(0,_words.Count);
        // }while (_generatedNumbers.Contains(random));

        // _generatedNumbers.Add(random);
        // int index = _generatedNumbers.IndexOf(_generatedNumbers.Last());
        // if (index > _words.Count){
        //     System.Environment.Exit(0);
        // }

        // for(int i = 0; i< _words.Count;i++){

        //     string hidden = _words[random].hideWord();
        //     _words[random].SetWord(hidden);

        // }

    }

    public void GetRenderedText()
    {
        Console.Write($"{reference.toString()}:");
        foreach (Word word in _words)
        {
            word.Display();
            Console.Write(" ");
        }
    }

    public bool AllWordsHiddenStatus()
    {
        foreach (Word word in _words)
        {

            if (!word.GetHidden())
                return false;
        }
        return true;
    }
}
