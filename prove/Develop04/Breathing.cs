using System;
//Derived Class

public class Breathing : Activities
{
    //Attributes


    //Getters


    //Setters


    //Constructors
    public Breathing(string activityName, string activityDescription) :base(activityName, activityDescription)
    {
        
    }

    //Methods
    public void GetBreathingCountdown()
    {
        Console.Write("Breathe in ...");        
        GetCountdown(3);
        Console.WriteLine("");
        Console.Write("Breathe out ...");
        GetCountdown(3);
        Console.WriteLine("");
    }

}