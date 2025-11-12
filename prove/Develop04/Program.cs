using System;

class Program
{
    static void Main(string[] args)
    {

        string menuSelection;
        do
        {

            //========= Menu =========
            Console.WriteLine("Menu options:");
            Console.WriteLine("(b) breathing activity)");
            Console.WriteLine("(r) reflection activity");
            Console.WriteLine("(l) listing activity");
            Console.WriteLine("(q) Quit");
            Console.Write("Select a choice from the menu: ");
            
            menuSelection = Console.ReadLine();
            Console.WriteLine("");

            //======== CALL ACTIONS =========
            //Breathing 
            if (menuSelection == "b")
            {
                Breathing breathingActivity = new Breathing("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.",0);
                breathingActivity.GetOpeningMessage();
                Console.WriteLine(breathingActivity.GetOpeningMessage());
                breathingActivity.GetDuration();
                breathingActivity.GetReadyAnimation();
                breathingActivity.SetTime();
                while (!breathingActivity.IsExpired())
                {
                    breathingActivity.GetBreathingCountdown();
                }
                breathingActivity.GetExitMessage();
            
            }

            //Reflection
            else if (menuSelection == "r")
            {
                Reflection reflectionActivity = new Reflection("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.",0);
                reflectionActivity.GetOpeningMessage();
                Console.WriteLine(reflectionActivity.GetOpeningMessage());
                reflectionActivity.GetDuration();
                reflectionActivity.GetReadyAnimation();
                reflectionActivity.GetPrompt1();
                reflectionActivity.SetTime();
                while (!reflectionActivity.IsExpired())
                {
                    reflectionActivity.GetPrompt2();
                }                
                reflectionActivity.GetExitMessage();
            }

            //Listing
            else if (menuSelection == "l")
            {
                Listing listingActivity = new Listing("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.",0);
                listingActivity.GetOpeningMessage();
                Console.WriteLine(listingActivity.GetOpeningMessage());
                listingActivity.GetDuration();
                listingActivity.GetReadyAnimation();
                listingActivity.SetTime();
                while (!listingActivity.IsExpired())
                {
                    listingActivity.GetListingPrompt();
                }                  
                listingActivity.GetExitMessage();           
            }            

        }
        while (menuSelection != "q");
    }
}