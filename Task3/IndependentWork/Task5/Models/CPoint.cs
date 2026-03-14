namespace Task3.IndependentWork.Task5.Models;

internal sealed class CPoint(double x, double y, string name) : CShape
{
    public double X => x;
    public double Y => y;
    
    public override double Square() => throw new NotSupportedException();

    public override void Show()
    {
        Console.WriteLine($"{nameof(CPoint)}:\n\tName{name}\n\tCoordinates: {this}");
    }

    public override string ToString() => $"({X}, {y})";
}