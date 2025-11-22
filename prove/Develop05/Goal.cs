//Base Class
public abstract class Goal
{
    private string _name;
    private string _description;
    private int _points;
    //attributes


    //getters
    public string Name
    {
        get
        {
            return _name;
        }
    }
        public string Description
    {
        get
        {
            return _description;
        }
    }
        public int Points
    {
        get
        {
            return _points;
        }
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

}