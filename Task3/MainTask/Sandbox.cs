using Shared.Geometry.MainTask;

namespace Task3.MainTask;

internal static class Sandbox
{
    public static void Main()
    {
        Triangle triangle = new Triangle(10, 20, 30);
        Pyramid pyramid = new Pyramid(10, 20, 30, 45);

        triangle.Show();
        pyramid.Show();
        
        Console.WriteLine(new string('-', 50));

        // Это будет работать т.к. Pyramid реализует Triangle
        triangle = pyramid;

        // Это не будет работать т.к. Triangle не реализует Pyramid
        // pyramid = triangle

        // Используется позднее связывание, поэтому вызывается метод из класса Pyramid 
        triangle.Show();
    }
}