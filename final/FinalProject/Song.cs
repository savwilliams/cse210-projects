using System.Text.Encodings.Web;

public class Song
{
    //attributes
    private string _title;
    private string _artist;
    private string _genre;
    private string _mood;
    private string _energy;

    //getters
    public string GetTitle()
    {
        return _title;
    }
    public string GetArtist()
    {
        return _artist;
    }
    public string GetGenre()
    {
        return _genre;
    }
    public string GetMood()
    {
        return _mood;
    }
    public string GetEnergy()
    {
        return _energy;
    }   

    //setters
    public void SetTitle(string value)
    {
        _title = value;
    }
        public void SetArtist(string value)
    {
        _artist = value;
    }
        public void SetGenre(string value)
    {
        _genre = value;
    }
        public void SetMood(string value)
    {
        _mood = value;
    }
        public void SetEnergy(string value)
    {
        _energy = value;
    }


    //constructors
    public Song(string title, string artist, string genre, string mood, string energy)
    {
        _title = title;
        _artist = artist;
        _genre = genre;
        _mood = mood;
        _energy = energy;        
    }


    //methods


}