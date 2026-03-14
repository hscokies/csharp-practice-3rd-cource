namespace Task3.IndependentWork.Task5.Models;

internal sealed class CRectangle(CPoint topLeft, double width, double height) : CShape
{
    private double Diagonal => Math.Sqrt(Math.Pow(width,2) + Math.Pow(height,2)); 
    
    public override double Square() => width * height;

    public override void Show()
    {
        Console.WriteLine($"{nameof(CCircle)}:" +
                          $"\n\tTop left corner:{topLeft}" +
                          $"\n\tWidth:{width}" +
                          $"\n\tHeight: {height}" +
                          $"\n\t{nameof(Diagonal)}:{Diagonal}");
    }
}