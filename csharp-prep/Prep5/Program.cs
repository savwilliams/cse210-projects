using System;
using System.Security.Cryptography.X509Certificates;

class Program
{


    //DisplayWelcome
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    //PromptUserName
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }

    //PromptUserNumber
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int favNumber = int.Parse(Console.ReadLine());
        return favNumber;
    }

    //PromtUserBirthYear
    static void PromtUserBirthYear(out int birthYear)
    {
        Console.Write("Please enter the year you were born: ");
        birthYear = int.Parse(Console.ReadLine());
    }

    //SquareNumber
    static int SquareNumber(int favNumber)
    {
        int sqNumber = favNumber * favNumber;
        return sqNumber;
    }

    //DisplayResults
    static void DisplayResult(string userName, int sqNumber, int birthYear)
    {

        Console.WriteLine($"{userName}, the square of your number is {sqNumber}");
        Console.WriteLine($"{userName}, you will turn {2025 - birthYear} this year");
    }

    //Main//
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();

        int favNumber = PromptUserNumber();

        int birthYear;
        PromtUserBirthYear(out birthYear);

        int sqNumber = SquareNumber(favNumber);

        DisplayResult(userName, sqNumber, birthYear);
    }













    
}