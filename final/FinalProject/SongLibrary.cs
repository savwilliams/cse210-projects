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
    public void LoadSongs(string filePath)
    {
        if (string.IsNullOrEmpty(filePath))
        {
            Console.WriteLine("Enter the file name for the playlist you want to load:");
            filePath = Console.ReadLine();
        }

        string[] lines = File.ReadAllLines(filePath);

        _fullSongList = new List<Song>(); 

        for (int i = 1; i < lines.Length; i++) 
        {
            string line = lines[i];
            string[] values = line.Split(',');

            string title = values[0];
            string artist = values[1];
            string genre = values[2];
            string mood = values[3];
            string energy = values[4];

            Song song = new Song(title, artist, genre, mood, energy);
            _fullSongList.Add(song);
        }
 
    }

}