//Base Class
public abstract class Goal
{
    private string _name;
    private string _description;
    private int _points;
    
    //attributes


    //getters
    public string GetName()
    {
        return _name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public int GetPoints()
    {
        return _points;
    }

    //setters


    //constructors
    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }


    //methods
    public abstract string DisplayGoal();
    public abstract int RecordEvent();
    public abstract bool IsComplete();

}