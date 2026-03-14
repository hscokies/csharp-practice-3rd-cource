namespace Task3.IndependentWork.Task3.Models;

internal sealed class RightTriangle(double verticalLeg, double horizontalLeg) : Shape
{
    public override double Area() => (verticalLeg * horizontalLeg) / 2;
}