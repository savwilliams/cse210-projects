using System;

class Program
{
    static void Main(string[] args)
    {
        string menuSelection;
        List<Goal> goalsList = new List<Goal>();
        int totalPoints = 0;
        do
        {
            //Menu
            Console.WriteLine($"You have {totalPoints} points. ");
            Level level = new Level();
            Console.WriteLine($"Your level is: {level.GetLevel(totalPoints)} ");

            Console.WriteLine("Menu options:");
            Console.WriteLine("(c) create new goal");
            Console.WriteLine("(li) list goals");
            Console.WriteLine("(s) save goals");
            Console.WriteLine("(lo) load goals");
            Console.WriteLine("(r) record event");
            Console.WriteLine("(q) Quit");
            Console.Write("Select a choice from the menu: ");
            
            menuSelection = Console.ReadLine();
            Console.WriteLine("");

            //Call actions
            //create new goal
            if (menuSelection == "c")
            {
                Console.WriteLine("The type of goals are:");
                Console.WriteLine("(s) simple goal");
                Console.WriteLine("(e) eternal goal");
                Console.WriteLine("(c) checklist goal");
                Console.WriteLine("What types of goal would you like to create? ");

                string goalType = Console.ReadLine();

                Console.Write("What is the name of your goal? ");
                string name = Console.ReadLine();      
                Console.Write("What is a short description of it? ");
                string description = Console.ReadLine();      
                Console.Write("How many points are associated with this goal? ");
                string pointsInput = Console.ReadLine();
                int points = int.Parse(pointsInput);
                
                Goal goal;
                //simple goal
                if (goalType == "s")
                {
                    goalsList.Add(goal = new SimpleGoal(name, description, points));
                }
                //eternal goal
                else if (goalType == "e")
                {
                    goalsList.Add(goal = new EternalGoal(name, description, points));
                }
                //checklist goal
                else if (goalType == "c")
                {
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    string timesUntilCompletionInput = Console.ReadLine();
                    int timesUntilCompletion = int.Parse(timesUntilCompletionInput);

                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    string bonusPointsInput = Console.ReadLine();
                    int bonusPoints = int.Parse(bonusPointsInput);

                    goalsList.Add(goal = new ChecklistGoal(name, description, points, bonusPoints, timesUntilCompletion, 0));
                }
            }

            //list goals
            else if (menuSelection == "li")
            {
                Console.WriteLine("The goals are: ");
                int index = 1;
                foreach (Goal goal in goalsList)
                {
                    Console.WriteLine($"{index}. {goal.DisplayGoal()}");
                    index++;
                }                
            }

            //save goals
            else if (menuSelection == "s")
            {
                Console.WriteLine("What is the filename for the goal file? ");
                string filename = Console.ReadLine();

                using (StreamWriter outputFile = new StreamWriter(filename))
                {
                    outputFile.WriteLine(totalPoints);
                    foreach (Goal goal in goalsList)
                    {
                        outputFile.WriteLine(goal.GetStringRepresentation());
                    }
                }
            }       

            //load goals
            else if (menuSelection == "lo")
            {
                Console.WriteLine("What is the filename for the goal file? ");
                string filename = Console.ReadLine();

                string[] lines = System.IO.File.ReadAllLines(filename);
                totalPoints = int.Parse(lines[0]);

                for (int index = 1; index < lines.Length; index++)
                {
                    string line = lines[index];
                    string[] parts = line.Split(":");

                    string goalType = parts[0];
                    string goalInfo = parts[1];

                    string[] goalValues = goalInfo.Split("|");

                    if (goalType == "SimpleGoal")
                    {
                        string name = goalValues[0];
                        string description = goalValues[1];
                        int points = int.Parse(goalValues[2]);
                        bool isComplete = bool.Parse(goalValues[3]);

                        SimpleGoal goal = new SimpleGoal(name, description, points);
                        goal.SetIsComplete(isComplete);
                        goalsList.Add(goal);
                    }
                    else if(goalType == "EternalGoal")
                    {
                        string name = goalValues[0];
                        string description = goalValues[1];
                        int points = int.Parse(goalValues[2]);

                        goalsList.Add(new EternalGoal(name, description, points));
                    }
                    else if(goalType == "ChecklistGoal")
                    {
                        string name = goalValues[0];
                        string description = goalValues[1];
                        int points = int.Parse(goalValues[2]);
                        int bonusPoints = int.Parse(goalValues[3]);
                        int timesUntilCompletion = int.Parse(goalValues[4]);
                        int timesCompleted = int.Parse(goalValues[5]);
                        
                        ChecklistGoal goal = new ChecklistGoal(name, description, points, bonusPoints, timesUntilCompletion, timesCompleted);
                        goal.SetTimesCompleted(timesCompleted);

                        goalsList.Add(goal);
                    }

                    Console.WriteLine("Loaded goals count: " + goalsList.Count);
                }

            }   

            //record event
            else if (menuSelection == "r")
            {
                Console.WriteLine("The goals are: ");
                int index = 1;
                foreach (Goal goal in goalsList)
                {
                    Console.WriteLine($"{index}. {goal.DisplayGoal()}");
                    index++;
                }     

                Console.WriteLine("")   ;
                Console.WriteLine("Which goal did you accomplish? ");
                int listIndex = int.Parse(Console.ReadLine()) - 1;
                Goal selectedGoal = goalsList[listIndex];
                int earnedPoints = selectedGoal.RecordEvent();
                totalPoints += earnedPoints;

                Console.WriteLine($"Congratulations! You earned {earnedPoints} points! ");                
            }   
        }
        while (menuSelection != "q");    
    }
}