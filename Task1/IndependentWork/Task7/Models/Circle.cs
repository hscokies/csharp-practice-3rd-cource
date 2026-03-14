using Shared.Geometry.Primitives;

namespace Task1.IndependentWork.Task7.Models;

internal sealed class Circle(Point center, double angle, double radius) : Shape(center, angle)
{
    private double _radius = radius;


    public static Circle Create(Point center, double angle, double radius)
    {
        return new Circle(center, angle, radius);
    }


    public override void Resize(double scale)
    {
        _radius *= scale;
    }

    public override string ToString()
    {
        return base.ToString() + $"\n{nameof(Circle)}\n\tRadius:{_radius}";
    }
}