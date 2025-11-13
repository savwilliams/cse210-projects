using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Square("Yellow", 4));
        shapes.Add(new Rectangle("Orange", 4, 8));
        shapes.Add(new Circle("Purple", 5));

        foreach(Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();
            Console.WriteLine($"Color: {color}");
            Console.WriteLine($"Area: {area}");
        }

        Square square1 = new Square("Green",2);
        square1.GetColor();
        square1.GetArea();
        Console.WriteLine(square1.GetColor());
        Console.WriteLine(square1.GetArea());

        Rectangle rectangle1 = new Rectangle("Blue",2,4);
        rectangle1.GetColor();
        rectangle1.GetArea();
        Console.WriteLine(rectangle1.GetColor());
        Console.WriteLine(rectangle1.GetArea());

        Circle circle1 = new Circle("Pink",3);
        circle1.GetColor();
        circle1.GetArea();
        Console.WriteLine(circle1.GetColor());
        Console.WriteLine(circle1.GetArea());


    }
}