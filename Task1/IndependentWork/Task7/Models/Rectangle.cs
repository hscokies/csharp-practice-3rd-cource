using Shared.Geometry.Primitives;

namespace Task1.IndependentWork.Task7.Models;

internal class Rectangle(Point center, double angle, double width, double height) : Shape(center, angle)
{
    private double _width = width;
    private double _height = height;


    public static Rectangle Create(Point center, double angle, double width, double height)
    {
        return new Rectangle(center, angle, width, height);
    }

    public override void Resize(double scale)
    {
        _width *= scale;
        _height *= scale;
    }

    public override string ToString()
    {
        return base.ToString() + $"\n{nameof(Rectangle)}\n\tWidth:{_width}\n\tHeight:{_height}";
    }
}