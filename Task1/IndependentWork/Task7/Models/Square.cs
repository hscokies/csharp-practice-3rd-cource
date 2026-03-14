using Shared.Geometry.Primitives;

namespace Task1.IndependentWork.Task7.Models;

internal sealed class Square(Point center, double angle, double side) : Rectangle(center, angle, side, side)
{
    public static Square Create(Point center, double angle, double side)
    {
        return new Square(center, angle, side);
    }
    
    public override string ToString()
    {
        return $"{nameof(Square)}:\n{base.ToString()}";
    }
}