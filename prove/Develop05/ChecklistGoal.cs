//Derived Class
public class ChecklistGoal : Goal
{
    //attributes
    private int _timesUntilCompletion;
    private int _bonusPoints;
    private int _timesCompleted;

    //getters
    public int GetTimesUntilCompletion()
    {
        return _timesUntilCompletion;
    }
    public int GetBonusPoints()
    {
        return _bonusPoints;
    }
    public int GetTimesCompleted()
    {
        return _timesCompleted;
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
        return $"[ ] {GetName()} ({GetDescription()}) --- Currently completed: {GetTimesCompleted()}/{GetTimesUntilCompletion()} ";
    }

    public override int RecordEvent()
    {
        if (_timesCompleted >= _timesUntilCompletion)
        {
            return 0;
        }

        _timesCompleted++;

        if (_timesCompleted == _timesUntilCompletion)
        {
            return GetPoints() + _bonusPoints;
        }
        else
        {
            return GetPoints();
        }
    }

}