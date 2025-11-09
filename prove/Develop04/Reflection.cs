//Derived Class

public class Reflection : Activities
{
    //Attributes


    //Getters


    //Setters


    //Constructors
    public Reflection(string activityName, string activityDescription) : base(activityName, activityDescription)
    {

    }


    //Methods
    // Get a random prompt
    // Get a random question about the prompt
    // Display the prompt
    // Display questions about the prompt and get answers
    


    
    public void GetPrompt1()
    {
        Console.WriteLine(" ");
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine(" ");

        List<string> promptList1 = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you did something truly selfless."
        };
        Random randomPrompt1 = new Random();
        int prompt1Index = randomPrompt1.Next(promptList1.Count);
        Console.WriteLine(promptList1[prompt1Index]);

        Console.WriteLine(" ");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.Read();
        Console.WriteLine(" ");
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.WriteLine(" ");
        Console.Write("You may begin in: ");
        GetCountdown(3);
              

    }
    

    public void GetPrompt2()
    {
        List<string> promptList2 = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
        Random randomPrompt2 = new Random();
        int prompt1Index2 = randomPrompt2.Next(promptList2.Count);
        Console.WriteLine(promptList2[prompt1Index2]);
        Thread.Sleep(3000);
    }

}