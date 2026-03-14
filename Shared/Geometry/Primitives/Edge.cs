namespace Shared.Geometry.Primitives;

public readonly record struct Edge(Point Start, Point End)
{
    public readonly Lazy<double> Distance = new(() => Math.Sqrt(Math.Pow(End.X - Start.X, 2) + Math.Pow(End.Y - Start.Y, 2)));
    
    public bool Intersects(Edge other)
    {
        var o1 = GeometryUtils.Orientation(Start, End, other.Start);
        var o2 = GeometryUtils.Orientation(Start, End, other.End);
        var o3 = GeometryUtils.Orientation(other.Start, other.End, Start);
        var o4 = GeometryUtils.Orientation(other.Start, other.End, End);

        // Для пересечения отрезки должны лежать по разные
        // стороны, следовательно, иметь разные знаки
        if (o1 * o2 < 0 && o3 * o4 < 0)
        {
            return true;
        }

        return
            (o1 == 0 && GeometryUtils.OnSegment(Start, End, other.Start)) ||
            (o2 == 0 && GeometryUtils.OnSegment(Start, End, other.End)) ||
            (o3 == 0 && GeometryUtils.OnSegment(other.Start, other.End, Start)) ||
            (o4 == 0 && GeometryUtils.OnSegment(other.Start, other.End, End));
    }

    public bool IsHorizontalIntersection(Edge other)
    {
        return Math.Abs(Start.Y - End.Y) < Constants.FloatingPointTolerance && Math.Abs(other.Start.Y - other.End.Y) < Constants.FloatingPointTolerance;
    }
}