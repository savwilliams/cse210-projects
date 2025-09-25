using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {

        int userNumberInput = -1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");

        List<int> numberList = new List<int>();


        while (userNumberInput != 0)
        {

            Console.Write("Enter number: ");

            userNumberInput = int.Parse(Console.ReadLine());

            if (userNumberInput != 0)
            {
                numberList.Add(userNumberInput);
            }

        }


        int sum = numberList.Sum();
        Console.WriteLine($"The sum is: {sum}");

        double avg = numberList.Average();
        Console.WriteLine($"The average is: {Math.Round(avg,2)}");

        int max_num = numberList.Max();
        Console.WriteLine($"The largest number is: {max_num}");

    }
}