using System.Linq;

public class Word

{
    //attributes
    private string _word = "";
    private bool _revealed;



    //constructors
    public Word(string w)
    {
        _word = w;
        _revealed = true;
    }


    //getters
    public bool IsRevealed()
    {
        return _revealed;
    }

    public string GetWord()
    {
        return _word;
    }


    //setters
    public void SetWord(string word)
    {
        _word = word;
    }

    //behaviors
    public void Hide()
    {
        int length = _word.Length;
        _word = new string('_', length);
        _revealed = false;
    }

    public void Display()
    {
        Console.Write($"{_word} ");
    }
}  