public class Playlist
{
    //attributes
    private string _playlistName;
    private List<Song> _songList;

    //getters
    public string GetPlaylistName()
    {
        return _playlistName;
    } 
    public List<Song> GetSongList()
    {
        return _songList;
    } 

    //setters
    public void SetPlaylistName(string value)
    {
        _playlistName = value;
    }

    //constructors
    public Playlist()
    {
        _songList = new List<Song>();
    }

    //methods


}