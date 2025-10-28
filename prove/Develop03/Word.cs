using System.Linq;

public class Word
//Keeps track of a single word and whether it is shown or hidden.
{
    //attributes
    private string _word;
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

    //setters
    

    //behaviors

    // Hide
        // Show
        // Is Hidden
        // Get Rendered Text
        
    public void Hide()
    {   int length = _word.Length;
        _word = new string('_', length);
        _revealed = false;
    }
    public void Display()
    {
        Console.Write($"{_word} ");
    }

} 