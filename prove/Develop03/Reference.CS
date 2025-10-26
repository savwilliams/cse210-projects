
public class Reference
//Keeps track of the book, chapter, and verse information.
{
    //attributes

    private string _bookName;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    //constructors
    public Reference(string bookName, int chapter, int verse)
    {
        _bookName = bookName;
        _chapter = chapter;
        _verse = verse;
        //handle single verse
    }

    public Reference(string bookName, int chapter, int verse, int endVerse)
    {
        _bookName = bookName;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
        //handle multiple verses
    }

    //getters
    public string GetBookName()
    {
        return _bookName;
    }
    public int GetChapter()
    {
        return _chapter;
    }
    public int GetVerse()
    {
        return _verse;
    }
    public int GetEndVerse()
    {
        return _endVerse;
    }


    //setters 

    
    //behaviors
    public string FullReference()
    {
        if (_endVerse == 0)        
            return _bookName + " " + _chapter + ":" + _verse;                   

        else        
            return _bookName + " " + _chapter + ":" + _verse + "-" + _endVerse;        
         
    }

}