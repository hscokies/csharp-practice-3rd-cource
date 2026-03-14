namespace Task3.IndependentWork.Task3.Models;

internal sealed class Circle(double radius) : Shape
{
    public override double Area() => Math.PI * Math.Pow(radius, 2);
}