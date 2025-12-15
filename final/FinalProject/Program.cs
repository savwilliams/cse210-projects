using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        //===== Local variables ===== 
        string moodSelection = "";
        string moodString = "";
        string genreSelection;
        string genreString = "";
        string energySelection = "";
        string energyString = "";
        List<string> validGenres;
        List<string> submenuChoices;
        List<string> submenuChoicesStrings;
        int counter = 0;


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
     
        moodSelection = Console.ReadLine().ToLower();

        if(moodSelection == "a")
            moodString = "Happy";
        else if(moodSelection == "b")
            moodString = "Sad";
        else if(moodSelection == "c")
            moodString = "Chill";
        else if(moodSelection == "d")
            moodString = "Intense";

        if (string.IsNullOrEmpty(moodString))
        {
            Console.WriteLine("Invalid mood selection. Exiting program.");
            return;         }

        validGenres = allowedMoods 
            .Where(entry => entry.Value.Contains(moodString))
            .Select(entry => entry.Key)
            .ToList();
            submenuChoicesStrings = validGenres;

        //-- Prompt for Genre --
        Console.WriteLine("=== Which genre are you most interested in listening to? ===");
        
        submenuChoices = new List<string>();
        counter = 0;

        foreach(string genreOption in submenuChoicesStrings)
        {
            submenuChoices.Add($"{(char)(97 + counter)}");
            Console.Write($"({submenuChoices[counter]})");
            Console.Write($" {genreOption}");
            Console.WriteLine();
            counter += 1;
        }
        
        genreSelection = Console.ReadLine().ToLower();
        int genreIndex = genreSelection[0] - 'a';

        if (genreIndex < 0 || genreIndex >= submenuChoicesStrings.Count)
        {
            Console.WriteLine("Invalid choice. Exiting program.");
            return; 
        }
        genreString = submenuChoicesStrings[genreIndex];

        List<string> energyOptions = allowedEnergyLevels[moodString];

        //-- Prompt for Energy Level --
        Console.WriteLine("=== What energy level do you want your playlist to have? ===");

        submenuChoicesStrings = energyOptions;
        submenuChoices = new List<string>();
        counter = 0;

        foreach(string energyOption in submenuChoicesStrings)
        {
            submenuChoices.Add($"{(char)(97 + counter)}");
            Console.Write($"({submenuChoices[counter]})");
            Console.Write($" {energyOption}");
            Console.WriteLine();
            counter += 1;
        }
        
        energySelection = Console.ReadLine().ToLower();
        int energyIndex = energySelection[0] - 'a';
        if (energyIndex < 0 || energyIndex >= submenuChoicesStrings.Count)
        {
            Console.WriteLine("Invalid choice. Exiting program.");
            return; 
        }
        energyString = submenuChoicesStrings[energyIndex];


    }
}