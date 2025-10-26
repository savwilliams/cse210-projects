public class Scripture
//Keeps track of the reference and the text of the scripture. Can hide words and get the rendered display of the text.
{
    //attributes
    private static List<Scripture> _scripturesList = new List<Scripture>
    {
        new Scripture("Thus God has provided a means that man, through faith, might work mighty miracles; therefore he becometh a great benefit to his fellow beings.", new Reference("Mosiah",8,18)),
        new Scripture("For, behold, I have refined thee, I have chosen thee in the furnace of affliction.", new Reference("1 Nephi",20,10)),
        new Scripture("Hast thou not known? hast thou not heard, that the everlasting God, the Lord, the Creator of the ends of the earth, fainteth not, neither is weary? there is no searching of his understanding.\nHe giveth power to the faint; and to them that have no might he increaseth strength.", new Reference("Isaiah",40,28,29))
    };

    private Random _randomScripture = new Random();
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
    public void Random()
    {
        int scripture = _randomScripture.Next(_scripturesList.Count);
        _selectedScripture = _scripturesList[scripture];
        Console.WriteLine(_scripturesList[scripture]);
    }

    public string Text()
    {
        
    }
    public void Display()
    {
        Console.WriteLine("");
        Console.WriteLine($"{_reference.FullReference()}");
        Console.WriteLine($"{_selectedScripture}");
        Console.WriteLine("");
    }
}