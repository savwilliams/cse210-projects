using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {

        Random randomNumberGenerator = new Random();
        int magicNumber = randomNumberGenerator.Next(1, 100);

        int userGuess = -1;
              
        while (magicNumber != userGuess)
        {
            Console.Write("What is your guess? ");

            userGuess = int.Parse(Console.ReadLine());

            if (userGuess < magicNumber)
            {
                Console.WriteLine("Higher");
            }

            if (userGuess > magicNumber)
            {
                Console.WriteLine("Lower");
            }

        }

        if (userGuess == magicNumber)
        {
            Console.WriteLine("You guessed it!");
        }
        
    }
}