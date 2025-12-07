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
    public Playlist(string playlistName)
    {
        _playlistName = playlistName;
        _songList = new List<Song>();
    }

    //methods
    public void AddSong()
    {
        //placeholder
    }
    public void RemoveSong()
    {
        //placeholder
    }
    public void DisplayPlaylist()
    {
        //placeholder
    }

}