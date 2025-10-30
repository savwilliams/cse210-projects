using System;

class Program
{
    static void Main(string[] args)
    {   
        Console.WriteLine("===================");
        Assignment simpleAssignment = new Assignment("Sam Holland","Multiplication");
        simpleAssignment.GetSummary();
        Console.WriteLine(simpleAssignment.GetSummary());
        Console.WriteLine("===================");

        MathAssignment mathAssignment1 = new MathAssignment("Barbara Fry", "Fractions", "Section 7.3", "Problems8-19");
        mathAssignment1.GetSummary();
        mathAssignment1.GetHomeworkList();
        Console.WriteLine(mathAssignment1.GetSummary());
        Console.WriteLine(mathAssignment1.GetHomeworkList());
        Console.WriteLine("===================");

        WritingAssignment writingAssignment1 = new WritingAssignment("Hannah Lars", "European History", "The Causes of World War II");
        writingAssignment1.GetSummary();
        writingAssignment1.GetWritingInformation();
        Console.WriteLine(writingAssignment1.GetSummary());
        Console.WriteLine(writingAssignment1.GetWritingInformation());
        Console.WriteLine("===================");
    }
}