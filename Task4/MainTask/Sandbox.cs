using Shared.Geometry.MainTask;
using Task4.MainTask.Models;

namespace Task4.MainTask;

internal static class Sandbox
{
    public static void Main()
    {
        var integers = new CustomStack<int>();
        integers.Push(1);
        integers.Push(2);
        integers.Push(3);
        Console.WriteLine(integers.Peek());
        Console.WriteLine(integers.Pop());
        Console.WriteLine(integers.Peek());
        
        
        var doubles = new CustomStack<double>();
        doubles.Push(1);
        doubles.Push(2);
        doubles.Push(3);
        
        // В первой лабораторной работе был треугольник
        var triangles = new CustomStack<Triangle>();
        triangles.Push(new Triangle(5,7,60));
        triangles.Push(new Triangle(8,6,120));
        triangles.Push(new Triangle(10,10,45));

        var topTriangle = triangles.Peek();
        Console.WriteLine($"Top triangle area: {topTriangle.Area()}");
    }
}