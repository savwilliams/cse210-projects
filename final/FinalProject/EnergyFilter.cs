//Derived Class
public class EnergyFilter : SongFilter
{
    //attributes
    private int _selectedEnergy; //may need to change to string later? 

    //getters


    //setters


    //constructors
    public EnergyFilter(int selectedEnergy)
    {
        _selectedEnergy = selectedEnergy;
    }
    

    //methods
    public override bool ApplyFilter()
    {
        return true;
    }

}