//Derived Class
public class GenreFilter : SongFilter
{
    //attributes
    private string _selectedGenre;

    //getters


    //setters


    //constructors
    public GenreFilter(string selectedGenre)
    {
        _selectedGenre = selectedGenre;
    }
    

    //methods
    public override bool ApplyFilter(Song song)
    {
        if(song.GetGenre() == _selectedGenre)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}