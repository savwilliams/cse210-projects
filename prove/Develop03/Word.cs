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
    public void Hide()
    {
        _revealed = false;
    }

    //behaviors
    public void Display()
    {
        if (_revealed)
        {
            Console.Write("" + _word);
        }
        else
        {
            Console.Write("__");
        }
    }
} 