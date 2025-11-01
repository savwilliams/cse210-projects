public class Scripture

{
    //attributes
    private Reference _reference;
    private string _selectedScripture;
    private List<Word> _wordList = new List<Word> { };
    private Random randomWord = new Random();

    //constructors
    public Scripture(string scriptureText, Reference reference)
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
        Console.WriteLine("=== Press enter to hide words, or 'q' to quit ===");
        Console.WriteLine(_reference.CompileReference());
        foreach (Word word in _wordList)
        {
            word.Display();
        }
    }

    public void HideRandomWords()
    {
        int randomIndex = randomWord.Next(_wordList.Count);
        _wordList[randomIndex].Hide();
    }

    public bool ScriptureFullyHidden()
    {
        foreach (Word w in _wordList)
        {
            if (w.IsRevealed())
                return false;
        }
        return true;
    }
}