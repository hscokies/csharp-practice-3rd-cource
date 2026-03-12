namespace TaskTwo.models;

public class Rectangle(Point start, double width, double height) : Shape
{
    protected override double Area { get; } = width * height;

    protected override Point[] Polygon { get; } =
    [
        start,
        start with { X = start.X + width },
        new Point(start.X + width, start.Y + height),
        start with { Y = start.Y + height },
    ];
}