using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {        
        Journal myJournal = new Journal();
        string menuSelection;
        
        do
        {
            //MENU
            Console.WriteLine("========= MENU =========");
            Console.WriteLine("(w) Write\n(d) Display\n(s) Save\n(l) Load\n(q) Quit");
            Console.Write("What would you like to do? ");
            menuSelection = Console.ReadLine();
            Console.WriteLine("");

            //CALL ACTIONS
            //Write
            if (menuSelection == "w")
            {
                Entry newEntry = new Entry();
                newEntry.Random();
                newEntry.Date();
                myJournal.AddEntry(newEntry);
                Console.WriteLine("==========================");
                Console.WriteLine("= Great Job! Keep it up! =");  
                Console.WriteLine("==========================");        
            }

            //Display
            if (menuSelection == "d")
            {
                myJournal.DisplayEntries();
            }

            //Save
            if (menuSelection == "s")
            {
                Console.WriteLine("Enter a file name (ex. journal.txt): ");
                string fileName = Console.ReadLine();                
                using (StreamWriter savedFile = new StreamWriter(fileName))
                {
                    foreach (Entry e in myJournal._journal)
                    {
                        savedFile.WriteLine(e.ToString());
                    }                    
                }
            }

            //Load
            if (menuSelection == "l")
            {
                Console.WriteLine("Enter a file name to load (ex. journal.txt): ");
                string fileName = Console.ReadLine();
                string[] lines = System.IO.File.ReadAllLines(fileName);       
                myJournal._journal = new List<Entry>();
 
                foreach (string line in lines)
                {
                    string[] index = line.Split("#");
                    string entryDate = index[0];
                    string selectedPrompt = index[1];
                    string userResponse = index[2];
                    Entry entry = new Entry(entryDate,selectedPrompt,userResponse);
                    myJournal.AddEntry(entry);
                }

                myJournal.DisplayEntries();
                Console.WriteLine();
            }

        }
        while (menuSelection != "q");
    }
}