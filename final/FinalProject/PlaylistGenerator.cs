public class PlaylistGenerator
{
    //attributes
    private SongLibrary _library;
    private List<SongFilter> _userFilters;

    //getters


    //setters


    //constructors
    public PlaylistGenerator(SongLibrary library)
    {
        _library = library;
        _userFilters = new List<SongFilter>();
    }

    //methods
    public void SetFilters(List<SongFilter> userFilters)
    {
        _userFilters = userFilters;
    }
    public Playlist CompilePlaylist(int numberOfSongs, string playlistName)
    {
        var query = 
            from song in _library.GetFullSongList()
            where SongPassesAllFilters(song)
            select song;

        List<Song> filteredSongs = query
            .Take(numberOfSongs)
            .ToList();

        Playlist playlist = new Playlist(playlistName);

        foreach(Song song in filteredSongs)
        {
            playlist.AddSong(song);
        }

        return playlist;
    }

    private bool SongPassesAllFilters(Song song)
    {
        foreach(SongFilter filter in _userFilters)
        {
            if(filter.ApplyFilter(song) == false)
            {
                return false;
            }
        }
        return true;
    }
}