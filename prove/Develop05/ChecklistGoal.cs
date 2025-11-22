//Derived Class
public class ChecklistGoal : Goal
{
    //attributes


    //getters


    //setters


    //constructors
    public ChecklistGoal(string name, string description, int points) : base(name, description, points)
    {

    }

    //methods
    public override string DisplayGoal()
    {
        return $"[ ] {Name} ({Description})";
    }

}