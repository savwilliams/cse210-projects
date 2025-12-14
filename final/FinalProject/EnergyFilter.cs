//Derived Class
public class EnergyFilter : SongFilter
{
    //attributes
    private string _selectedEnergy; 

    //getters


    //setters


    //constructors
    public EnergyFilter(string selectedEnergy)
    {
        _selectedEnergy = selectedEnergy;
    }
    

    //methods
    public override bool ApplyFilter(Song song)
    {
        if(song.GetEnergy() == _selectedEnergy)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}