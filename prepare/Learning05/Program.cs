using System;

class Program
{
    static void Main(string[] args)
    {
        Square square1 = new Square("Green",2);
        square1.GetColor();
        square1.GetArea();
        Console.WriteLine(square1.GetColor());
        Console.WriteLine(square1.GetArea());
    }
}