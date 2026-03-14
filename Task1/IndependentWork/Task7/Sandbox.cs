using Shared.Geometry.Primitives;
using Task1.IndependentWork.Task7.Models;
using Shape = Task1.IndependentWork.Task7.Models.Shape;

namespace Task1.IndependentWork.Task7;

internal static class Sandbox
{
    public static void Main()
    {
        var center = new Point(0, 0);
        var moveDelta = new Point(-3, 10);
        
        var circle = Circle.Create(center, 20, 30);
        HandleShape(circle, center, moveDelta);
        
        var rectangle = Rectangle.Create(center, -20, 30, 20);
        HandleShape(rectangle, center, moveDelta);
        
        var square = Square.Create(center, 180, 15);
        HandleShape(square, center, moveDelta);
    }

    private static void HandleShape(Shape shape, Point center, Point moveDelta)
    {
        PrintHeader(shape.GetType().Name);
        Console.WriteLine(shape);
        shape.Resize(5.5);
        shape.Move(moveDelta);
        shape.Rotate(-361);
        
        Console.WriteLine(new string('=', 30));
        Console.WriteLine(shape);
    }
    
    private static void PrintHeader(string text)
    {
        var decoration = new string('=', 10);
        Console.WriteLine($"{decoration}{text}{decoration}");
    }
}