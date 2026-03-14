namespace Task3.IndependentWork.Task3.Models;

internal sealed class Trapezoid(double topBase, double bottomBase, double height) : Shape
{
    public override double Area() => (topBase * bottomBase) / 2 * height;
}