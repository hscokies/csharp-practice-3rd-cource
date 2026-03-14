namespace Task3.IndependentWork.Task3.Models;

internal sealed class Rectangle(double width, double height) : Shape
{
    public override double Area() => width * height;
}