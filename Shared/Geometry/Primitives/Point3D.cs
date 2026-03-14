namespace Shared.Geometry.Primitives;

public readonly record struct Point3D(double X, double Y, double Z)
{
    public override string ToString()
    {
        return $"({X}, {Y}, {Z})";
    }
}