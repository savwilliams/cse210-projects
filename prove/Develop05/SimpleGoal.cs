//Derived Class
public class SimpleGoal : Goal
{
    //attributes


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
}