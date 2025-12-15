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
    public void AddSong(Song song)
    {
        _songList.Add(song);
    }
    public void RemoveSong()
    {
        //placeholder
    }
    public void DisplayPlaylist()
    {
        Console.WriteLine();
        Console.WriteLine($"===== Playlist: {_playlistName} =====");

        int songNumber = 1;

        foreach(Song song in _songList)
        {
            Console.WriteLine($"{songNumber}. {song.GetTitle()} by {song.GetArtist()}");
            songNumber++;
        }

        Console.WriteLine("===============================");
    }

}