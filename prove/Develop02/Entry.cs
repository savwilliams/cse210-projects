using System.Collections.Generic;
public class Entry
{
    //attributes
    private static List<string> _prompts = new List<string>
    {
        "What was one good thing that happened to you today?",
        "What is one thing that you learned today?",
        "Describe a favorite moment from today.",
        "What is one thing you're grateful for?",
        "What emotion did you feel the most today?"
    };
    private Random _getRandomPrompt = new Random();
    private string _selectedPrompt;
    private string _userResponse;
    private string _entryDate;


    //constructors
    public Entry()
    {
        _userResponse = "";
        _selectedPrompt = "";
        _entryDate = "";
    }

    public Entry(string entryDate, string selectedPrompt, string userResponse)
    {
        _entryDate = entryDate;
        _selectedPrompt = selectedPrompt;
        _userResponse = userResponse;        
    }


    //behaviors
    public void Random()
    {
        int prompt = _getRandomPrompt.Next(_prompts.Count);
        Console.WriteLine(_prompts[prompt]);
        _selectedPrompt = _prompts[prompt];
        _userResponse = Console.ReadLine();
    }

    public void Date()
    {
        _entryDate = DateTime.Now.ToShortDateString();
        //Console.WriteLine(_entryDate);   
    }

    public void Display()
    {
        Console.WriteLine("========= Journal Entry ========");
        Console.WriteLine($"Prompt: {_selectedPrompt}\nResponse: {_userResponse}\nDate: {_entryDate}");
        Console.WriteLine("================================");
    }

    public override string ToString()
    {
        return $"{_entryDate}#{_selectedPrompt}#{_userResponse}";
    }
}