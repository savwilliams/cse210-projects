//Base class

public class Activities
{
    //Attributes

    //starting message
    private string _activityName = "";
    private string _activityDescription = "";
    private int _duration;

    //Getters
    //use getter and setter if one the attributes above need 
    //to be used in a method in another class

    //Setters


    //Constructors
    public Activities(string activityName, string activityDescription)
    {
        _activityName = activityName;
        _activityDescription = activityDescription;
        _duration = 0;
    }


    //Methods
    public string GetOpeningMessage()
    {
        return $"Welcome to the {_activityName} Activity.\n{_activityDescription}\nHow long in seconds would you like for your session?";
    }



}