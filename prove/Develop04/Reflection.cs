//Derived Class

public class Reflection : Activities
{
    //Attributes


    //Getters


    //Setters


    //Constructors
    public Reflection(string activityName, string activityDescription) :base(activityName, activityDescription)
        {
            
        }

    //Methods
        // Get a random prompt
        // Get a random question about the prompt
        // Display the prompt
        // Display questions about the prompt and get answers
    public void GetRandomPrompt()
    {
        Console.WriteLine("Consider the following prompt:");

        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");        
        GetCountdown(3);
    }
}