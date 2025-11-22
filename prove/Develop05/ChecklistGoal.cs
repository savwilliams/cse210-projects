//Derived Class
public class ChecklistGoal : Goal
{
    //attributes
    private int _timesUntilCompletion;
    private int _bonusPoints;

    //getters
    public int GetTimesUntilCompletion()
    {
        return _timesUntilCompletion;
    }
    public int GetBonusPoints()
    {
        return _bonusPoints;
    }

    //setters


    //constructors
    public ChecklistGoal(string name, string description, int points, int timesUntilCompletion, int bonusPoints) : base(name, description, points)
    {
         _timesUntilCompletion = timesUntilCompletion;
         _bonusPoints = bonusPoints;
    }

    //methods
    public override string DisplayGoal()
    {
        return $"[ ] {GetName()} ({GetDescription()}) --- Currently completed: []/{GetTimesUntilCompletion()} ";
    }

}