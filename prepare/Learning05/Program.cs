using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapeList = [
        new Square("red", 21),
        new Rectangle("blue", 3, 5),
        new Circle("Orange", 2.63)
        ];
        foreach(Shape shape in shapeList)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }
    }
}