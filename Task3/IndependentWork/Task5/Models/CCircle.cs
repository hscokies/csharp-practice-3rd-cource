namespace Task3.IndependentWork.Task5.Models;

internal sealed class CCircle(CPoint center, double radius) : CShape
{
    private double Diameter => 2 * radius;
    private double Circumference => 2 * Math.PI * radius;
    
    public override double Square() => Math.PI * Math.Pow(radius, 2);
    

    public override void Show()
    {
        Console.WriteLine($"{nameof(CCircle)}:" +
                          $"\n\tCenter:{center}" +
                          $"\n\tRadius:{radius}" +
                          $"\n\t{nameof(Diameter)}: {Diameter}" +
                          $"\n\t{nameof(Circumference)}:{Circumference}");
    }
}