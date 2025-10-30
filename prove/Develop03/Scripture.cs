public class Scripture
//Keeps track of the reference and the text of the scripture. Can hide words and get the rendered display of the text.
{
    //attributes
    private Reference _reference;
    private string _selectedScripture;
    private List<Word> _wordList = new List<Word> { };
    
    //constructors
    public Scripture(string scriptureText,Reference reference)
    {
        _selectedScripture = scriptureText;
        _reference = reference;
    
        string[] splitWords = _selectedScripture.Split(' ');
        
        foreach (string w in splitWords)
        {
            Word word = new Word(w);
            _wordList.Add(word);
        }
    }

    //getters
    public string GetScripture()
    {
        return _selectedScripture;
    }

    //setters

    //behaviors
    public void Display()
    {
        Console.Clear();
        Console.WriteLine("Press enter to clear words, and 'q' to quit");
        Console.WriteLine(_reference.CompileReference());
        foreach (Word word in _wordList)
        {
            word.Display();
        }
    }

    public void HideRandomWords()
    {
        foreach (Word randomWord in _wordList)
        {
            randomWord.Display();
        }
        word.Hide();
    }

    public bool ScriptureFullyHidden()
    {
        return true;
    }    
}