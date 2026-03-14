namespace Shared.Geometry.Primitives;

public abstract class Shape
{
    public abstract double Area();

    public override string ToString()
    {
        return $"{nameof(Shape)}:\n\t{nameof(Area)}:{Area()}";
    }

    public int Compare(Shape other)
    {
        return Area().CompareTo(other.Area());
    }
}