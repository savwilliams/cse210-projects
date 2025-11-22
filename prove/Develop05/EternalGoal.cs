//Derived Class
public class EternalGoal : Goal
{
    //attributes


    //getters


    //setters


    //constructors
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {

    }

    //methods
    public override string DisplayGoal()
    {
        return $"[ ] {GetName()} ({GetDescription()})";
    }

}