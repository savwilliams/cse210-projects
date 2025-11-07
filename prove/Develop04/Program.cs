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
                Activities openingMessage = new Activities("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                openingMessage.GetOpeningMessage();
                Console.WriteLine(openingMessage.GetOpeningMessage());
                
            
            }

            //Reflection
            else if (menuSelection == "r")
            {
                Activities openingMessage = new Activities("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                openingMessage.GetOpeningMessage();
                Console.WriteLine(openingMessage.GetOpeningMessage());
            }

            //Listing
            else if (menuSelection == "l")
            {
                Activities openingMessage = new Activities("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                openingMessage.GetOpeningMessage();
                Console.WriteLine(openingMessage.GetOpeningMessage());               
            }            

        }
        while (menuSelection != "q");
    }
}