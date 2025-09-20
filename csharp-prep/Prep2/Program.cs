using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your grade percentage:");

        string userInput = Console.ReadLine();

        int userGrade = int.Parse(userInput);

        string letter = "";

        if (userGrade >= 90)
        {
            letter = "A";
        }

        else if (userGrade >= 80 && userGrade < 90)
        {
            letter = "B";
        }

        else if (userGrade >= 70 && userGrade < 80)
        {
            letter = "C";
        }

        else if (userGrade >= 60 && userGrade < 70)
        {
            letter = "D";
        }

        else if (userGrade < 60)
        {
            letter = "D";
        }

        Console.WriteLine($"Your letter grade is: {letter}");

        if (letter == "A" || letter == "B" || letter == "C")
        {
            Console.Write("Congratulations! You have passed your class.");
        }

        else
        {
            Console.Write("Sorry, you have not passed your class. Please try again!");
        }
    }
}