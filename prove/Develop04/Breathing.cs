using System;
//Derived Class

public class Breathing : Activities
{
    //Attributes


    //Getters


    //Setters


    //Constructors
    public Breathing(string activityName, string activityDescription, int duration) :base(activityName, activityDescription, duration)
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