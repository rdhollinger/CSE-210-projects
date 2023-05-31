public class Word
{
    private string _word;
    private bool _hidden;

    public Word(string word){
        _word = word;
        _hidden = false;
    }
    
    public void Display(){
        if (_hidden)
        {
            foreach(char letter in _word)
            {
                Console.Write("_");
            }
        }
        else
            Console.Write(_word);
    }
  
    public void HideWord()
    {
        _hidden = true;
    }

    public bool GetHidden()
    {
        return _hidden;
    }

}
