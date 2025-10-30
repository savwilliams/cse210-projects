using System;

class Program
{
    static void Main(string[] args)
    {

        Reference mosiah = new Reference("Mosiah", 8, 18);
        Reference nephi = new Reference("1 Nephi", 20, 10);
        Reference isaiah = new Reference("Isaiah", 40, 28, 29);

        List<Scripture> scripturesList = new List<Scripture>
        {
            new Scripture("Thus God has provided a means that man, through faith, might work mighty miracles; therefore he becometh a great benefit to his fellow beings.", mosiah),

            new Scripture("For, behold, I have refined thee, I have chosen thee in the furnace of affliction.", nephi),

            new Scripture("Hast thou not known? hast thou not heard, that the everlasting God, the Lord, the Creator of the ends of the earth, fainteth not, neither is weary? there is no searching of his understanding.\nHe giveth power to the faint; and to them that have no might he increaseth strength.", isaiah)
        };

        Random randomGenerator = new Random();

        int scriptureIndex = randomGenerator.Next(scripturesList.Count);
        Scripture selectedScripture = scripturesList[scriptureIndex];

        string userInput;
        
        do
        {
            selectedScripture.Display();
            selectedScripture.HideRandomWords();
            userInput = Console.ReadLine();

        }
        while (userInput != "q" && !selectedScripture.ScriptureFullyHidden());

        


        // Word word = new Word("Hello");
        // Word word1 = new Word("yellow");
        // Word word2 = new Word("flower");

        // List<Word> _testwordlist = new List<Word>
        // {
        //     word, word1, word2
        // };

        // foreach (Word randomword in _testwordlist)
        // {
        //     randomword.Display();
        // }

        // // pick a random word from the scripture (list of words associated with the scripture)
        // word1.Hide();
        // foreach (Word randomword in _testwordlist)
        // {
        //     randomword.Display();
        // }

        
    }

        
} 