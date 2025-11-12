//Derived Class
public class Listing : Activities
{
    //Attributes
    List<string> userList = new List<string>();
    string userInput;

    //Getters

    //Setters

    //Constructors
    public Listing(string activityName, string activityDescription, int duration) :base(activityName, activityDescription, duration)
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
        Console.WriteLine($"--- {promptList[promptListingIndex]} ---");

        Console.WriteLine(" ");
        Console.WriteLine("You may begin in: ");
        GetCountdown(5);
    }
    
    public void GetUserList()
    {        
        Console.Write(">");
        userInput = Console.ReadLine();
        userList.Add(userInput);
    }
    
    public void GetListCount()
    {
        Console.WriteLine(" ");
        int listCount = userList.Count;
        Console.WriteLine($"You listed {listCount} items!");
    }
}