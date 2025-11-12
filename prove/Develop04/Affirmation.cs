//Derived Class

public class Affirmation : Activities
{
    //Attributes

    //Getters

    //Setters

    //Constructors
    public Affirmation(string activityName, string activityDescription, int duration) : base(activityName, activityDescription, duration)
    {

    }

    //Methods
    public void GetAffirmationIntro()
    {
        Console.WriteLine(" ");
        Console.WriteLine("Repeat each affirmation out loud three times.");
        Console.WriteLine(" ");
        Console.WriteLine("You may begin in: ");
        GetCountdown(5);
    }

    public void GetRandomAffirmation()
    {
        List<string> AffirmationList = new List<string>
        {
            "I choose to focus on what I can control rather than what I can't.",
            "Every challenge is an opportunity for me to learn and grow.",
            "This too shall pass.",
            "This feeling is only temporary.",
            "I am loved and accepted just as I am.",
            "I am strong and resilient.",
            "I am enough.",
            "It is okay to pause and take a break."
        };

        Random randomAffirmation = new Random();
        int affirmationIndex = randomAffirmation.Next(AffirmationList.Count);
        Console.WriteLine(" ");

        for (int i = 0; i < 3; i++)
        {
            Console.Write($"--- {AffirmationList[affirmationIndex]} --- ");
            GetAnimation();
        }

        Console.WriteLine(" ");
    }
}