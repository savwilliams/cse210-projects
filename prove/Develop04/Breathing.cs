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
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
        Console.Write("Breathe out ...");
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }

}