using System;

class Program
{
    static void Main(string[] args)
    {
        
        string menuSelection = "";

        while (menuSelection != "q")
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
                Entry dailyEntry = new Entry();
                Console.WriteLine(dailyEntry);



                Entry newEntry = new Entry();
                Console.WriteLine(newEntry.display);
            }

                //Display
            if (menuSelection == "d")
            {

            }

                //Save
            if (menuSelection == "s")
            {

            }

                //Load
            if (menuSelection == "l")
            {

            }

            
            
        }
    }
}