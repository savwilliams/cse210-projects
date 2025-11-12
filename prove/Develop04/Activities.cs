using System;

//Base class
public class Activities
{
    //Attributes

    //starting message
    private string _activityName = "";
    private string _activityDescription = "";
    private int _duration;    
    private DateTime _futureTime;

    //Getters
    public DateTime GetFutureTime()
    {
        return _futureTime;
    }

    //Setters

    //Constructors
    public Activities(string activityName, string activityDescription, int duration)
    {
        _activityName = activityName;
        _activityDescription = activityDescription;
        _duration = duration;
    }

    //Methods
    public string GetOpeningMessage()
    {
        return $"Welcome to the {_activityName} Activity.\n{_activityDescription}";
    }

    public int GetDuration()
    {
        Console.WriteLine(" ");
        Console.Write("How long in seconds would you like for your session? ");
        string duration = Console.ReadLine();
        _duration = Int32.Parse(duration);
        return _duration;      
    }

    public void GetAnimation()
    {
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(3);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(200);
            Console.Write("\b \b");

            i++;

            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }
    }
        
    public void GetReadyAnimation()
    {
        Console.WriteLine("Get ready...");        
        GetAnimation();
    }

    public void GetExitMessage()
    {
        Console.WriteLine(" ");
        Console.WriteLine("Well done!");        
        GetAnimation();
        Console.WriteLine($"You have completed {_duration} seconds of the {_activityName} Activity");
        GetAnimation();
        Console.WriteLine(" ");
    }

    public void GetCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void SetTime()
    {
        DateTime startTime = DateTime.Now;
        _futureTime = startTime.AddSeconds(_duration);        
    }

    public bool IsExpired()
    {
        return DateTime.Now >= _futureTime;
    }
}