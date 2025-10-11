using System.Collections.Generic;
public class Entry
{

    public static List<string> _prompts = new List<string>();
    

    public Random _getRandomPrompt = new Random();
    public string _selectedPrompt = "";
    public string _userResponse = "";

    public string _entryDate;

    public Entry()
    {
        _prompts = new List<string>();
        _prompts.Add("What was one good thing that happened to you today?");
        _prompts.Add("What is one thing that you learned today?");
        _prompts.Add("Describe a favorite moment from today.");
        _prompts.Add("What is one thing you're grateful for?");
        _prompts.Add("What emotion did you feel the most today?");

        int prompt = _getRandomPrompt.Next(_prompts.Count);
        Console.WriteLine(_prompts[prompt]);
        _selectedPrompt = _prompts[prompt];

        _entryDate = DateTime.Now.ToShortDateString();
        //Console.WriteLine(entryDate);

        _userResponse = Console.ReadLine();        

    }


    public void display()
    {
        Console.WriteLine($"{_selectedPrompt}/n{_userResponse}/n{_userResponse}");
    }

}