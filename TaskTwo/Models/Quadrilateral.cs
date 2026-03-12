namespace TaskTwo.models;

public class Quadrilateral : Shape
{
    protected override double Area { get; }
    protected override Point[] Polygon { get; }

    private Quadrilateral(Edge ab, Edge bc, Edge cd, Edge da)
    {
        Polygon = [ab.Start, bc.Start, cd.Start, da.Start];

        var abDistance = ab.Distance.Value;
        var bcDistance = bc.Distance.Value;
        var cdDistance = cd.Distance.Value;
        var daDistance = da.Distance.Value;

        var halfPerimeter = (abDistance + bcDistance + cdDistance + daDistance) / 2;
        Area = Math.Sqrt(
            (halfPerimeter - abDistance) * (halfPerimeter - bcDistance) *
            (halfPerimeter - cdDistance) * (halfPerimeter - daDistance));
    }

    public static Quadrilateral Create(Point a, Point b, Point c, Point d)
    {
        var ab = new Edge(a, b);
        var bc = new Edge(b, c);
        var cd = new Edge(c, d);
        var ad = new Edge(d, a);
        var ac = new Edge(a, c);
        var bd = new Edge(b, d);

        var left = ac.Distance.Value * bd.Distance.Value;
        var right = ab.Distance.Value * cd.Distance.Value + ad.Distance.Value * bc.Distance.Value;

        bool isCyclic = Math.Abs(left - right) < Constants.FloatTolerance;
        return !isCyclic
            ? throw new ArgumentException("Ожидается вписанный четырехугольник")
            : new Quadrilateral(ab, bc, cd, new Edge(d, a));
    }
}