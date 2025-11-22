//Derived Class
public class SimpleGoal : Goal
{
    //attributes
    private bool _isComplete;

    //getters


    //setters


    //constructors
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {

    }

    //methods
    public override string DisplayGoal()
    {
        return $"[ ] {GetName()} ({GetDescription()})";
    }

    public override int RecordEvent()
    {
        if (_isComplete == true)
        {
            return 0;
        }
        else
        {
            _isComplete = true;
            return GetPoints();
        }
    }
}