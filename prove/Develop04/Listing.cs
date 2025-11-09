//Derived Class

public class Listing : Activities
{
    //Attributes


    //Getters


    //Setters


    //Constructors
    public Listing(string activityName, string activityDescription) :base(activityName, activityDescription)
        {
            
        }

    //Methods
    public void GetListingPrompt()
    {
        Console.WriteLine(" ");
        Console.WriteLine("List as many responses as you can to the following prompt: ");
        Console.WriteLine(" ");

        List<string> promptList = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
        Random randomListingPrompt = new Random();
        int promptListingIndex = randomListingPrompt.Next(promptList.Count);
        Console.WriteLine(promptList[promptListingIndex]);

        Console.WriteLine(" ");
        Console.Write("You may begin in: ");
        GetCountdown(3);
        Console.WriteLine(">");
        Console.ReadLine();
    }
    

}