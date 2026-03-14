using Task3.IndependentWork.Task3.Models;

namespace Task3.IndependentWork.Task3;

internal static class Sandbox
{
    public static void Main()
    {
        Shape[] figures =
        [
            new Rectangle(5, 4),
            new Circle(3),
            new RightTriangle(6, 8),
            new Trapezoid(4, 6, 5)
        ];

        foreach (var figure in figures)
        {
            Console.WriteLine($"{figure.GetType().Name} area: {figure.Area()}");
        }
    }
}