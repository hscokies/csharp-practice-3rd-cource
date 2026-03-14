namespace Task3.IndependentWork.Task5.Models;

internal sealed class CTriangle(double a,  double b, double angleAb) : CShape
{
    private double AngleAbRad => angleAb * Math.PI / 180d;
    private double C => Math.Sqrt(a * a + b * b - 2 * a * b * Math.Cos(AngleAbRad));

    public override double Square() => 0.5 * a * b * Math.Sin(AngleAbRad);

    public override void Show()
    {
        Console.WriteLine($"{nameof(CTriangle)}" +
                          $"\n\tSide A: {a}" +
                          $"\n\tSide B: {b}" +
                          $"\n\tSide C: {C}" +
                          $"\n\tAngle AB: {angleAb} deg" +
                          $"\n\tAngle AB {AngleAbRad} rad");
    }
}