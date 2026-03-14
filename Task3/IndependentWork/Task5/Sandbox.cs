using Task3.IndependentWork.Task5.Models;

namespace Task3.IndependentWork.Task5;

internal static class Sandbox
{
    public static void Main()
    {
        var point = new CPoint(-48.876667, -123.393333, "Nemo");
        point.Show();
        
        var circle = new CCircle(point, 15);
        circle.Show();
        
        var rectangle = new CRectangle(point, 30, 20);
        rectangle.Show();

        var triangle = new CTriangle(10, 20, 30);
        triangle.Show();
    }
}