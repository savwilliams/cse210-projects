public class SongLibrary
{
    //attributes
    private List<Song> _fullSongList;

    //getters
    public List<Song> GetFullSongList()
    {
        return _fullSongList;
    } 

    //setters


    //constructors
    public SongLibrary()
    {
        _fullSongList = new List<Song>();
    }

    //methods
    public void LoadSongs()
    {
        //placeholder
    }

}