namespace TaskTwo.models;

public class Triangle(Point a, Point b, Point c) : Shape
{
    protected override double Area { get; } = Math.Abs((a.X * (b.Y - c.Y) + b.X * (c.Y - a.Y) + c.X * (a.Y - b.Y)) / 2);

    protected override Point[] Polygon { get; } = [a, b, c];
}