//Derived Class
public class MoodFilter : SongFilter
{
    //attributes
    private string _selectedMood;

    //getters


    //setters


    //constructors
    public MoodFilter(string selectedMood)
    {
        _selectedMood = selectedMood;
    }
    

    //methods
    public override bool ApplyFilter()
    {
        return true;
    }

}