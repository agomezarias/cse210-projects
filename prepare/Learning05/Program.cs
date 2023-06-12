using System;

class Program
{
    static void Main(string[] args)
    {
        // Square square1 = new Square("purple",4);
        // Console.WriteLine (square1.GetColor());
        // Console.WriteLine (square1.GetArea());

        // Rectangle rect1 = new Rectangle("pink", 4, 5);
        // Console.WriteLine(rect1.GetColor());
        // Console.WriteLine(rect1.GetArea());

        // Circle circle1 = new Circle("red", 4);
        // Console.WriteLine(circle1.GetColor());
        // Console.WriteLine(circle1.GetArea());

        //shape#
        Square shape1 = new Square("purple", 4);
        Rectangle shape2 = new Rectangle("pink", 4, 5);
        Circle shape3 = new Circle("red", 4);

        List<Shape> shapes = new List<Shape>();
        
        //adding to list
        shapes.Add(shape1);
        shapes.Add(shape2);
        shapes.Add(shape3);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"The {color} {shape} has an area of {area}");
        }

    }
}