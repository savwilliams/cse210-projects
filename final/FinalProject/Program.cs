using System;

class Program
{
    static void Main(string[] args)
    {
        //===== Local variables ===== 
        string moodSelection;
        string moodString = "" ;

        //===== Questionaire Dictionaries ===== 
        Dictionary<string, List<string>> allowedMoods = new Dictionary<string, List<string>>
        {
            {"Rock", new  List<string> {"Happy", "Sad", "Chill", "Intense"}},
            {"Electronic Dance Music", new  List<string> {"Happy", "Chill", "Intense"}},
            {"Pop", new  List<string> {"Happy", "Sad", "Chill"}},
            {"Folk", new  List<string> {"Happy", "Sad", "Chill"}},
        };

        Dictionary<string, List<string>> allowedEnergyLevels = new Dictionary<string, List<string>>
        {
            {"Happy", new  List<string> {"Low", "Medium", "High"}},
            {"Sad", new  List<string> {"Low", "Medium"}},
            {"Chill", new  List<string> {"Low", "Medium"}},
            {"Intense", new  List<string> {"Medium", "High"}},
        };

        //===== Questionaire Menu ===== 
        Console.WriteLine("Welcome to your playlist generator! Complete a questionaire and I'll curate a personalized playlist for you!");
        Console.WriteLine("=== Press enter to begin ===");
        Console.ReadLine();

            //-- Prompt for Mood --        
        Console.WriteLine("=== What mood are you looking for? ===");
        Console.WriteLine("(a) Happy");
        Console.WriteLine("(b) Sad");
        Console.WriteLine("(c) Chill");
        Console.WriteLine("(d) Intense");        
        moodSelection = Console.ReadLine();

        if(moodSelection == "a")
            moodString = "Happy";
        else if(moodSelection == "b")
            moodString = "Sad";
        else if(moodSelection == "c")
            moodString = "Chill";
        else if(moodSelection == "d")
            moodString = "Intense";


        //List<string> moodOptions = 
        // IEnumerable<string> query = allowedMoods[moodString].Where(word => word.Length == 3);

        // foreach (string str in query)
        // {
        //     Console.WriteLine(str);
        // }

            //-- Prompt for Genre --
        Console.WriteLine("=== Which genre are you most interested in listening to? ===");
        Console.WriteLine("(a) Rock");
        Console.WriteLine("(b) Electronic Dance Music");
        Console.WriteLine("(c) Pop");
        Console.WriteLine("(d) Folk");
        

            //-- Prompt for Energy Level --
        Console.WriteLine("=== What energy level do you want your playlist to have? ===");
        Console.WriteLine("(a) Low");
        Console.WriteLine("(b) Medium");
        Console.WriteLine("(c) High");
        Console.ReadLine();
        
    }
}