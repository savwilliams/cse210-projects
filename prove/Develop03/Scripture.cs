public class Scripture
{
    //attributes
    private string _selectedScripture;

    private static List<string> _scripturesList = new List<string>();


    //constructors
    public Scripture()
    {
        _scripturesList = new List<string>();
        _scripturesList.Add("Thus God has provided a means that man, through faith, might work mighty miracles; therefore he becometh a great benefit to his fellow beings.");
        _scripturesList.Add("For, behold, I have refined thee, I have chosen thee in the furnace of affliction.");
        _scripturesList.Add("Hast thou not known? hast thou not heard, that the everlasting God, the Lord, the Creator of the ends of the earth, fainteth not, neither is weary? there is no searching of his understanding.\nHe giveth power to the faint; and to them that have no might he increaseth strength.");
        

    }

    
    //getters


    //setters


    //methods
    public void display()
    {
        Console.WriteLine($"{_selectedScripture}");
    }

}