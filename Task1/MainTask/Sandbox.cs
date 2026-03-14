using Shared.Geometry.MainTask;

namespace Task1.MainTask;

public static class Sandbox
{
    public static void Main()
    {
        // Массив объектов
        Triangle[] trianglesCollection =
        [
            new(3, 4, 60),
            new(2, 7, 30),
            new(5, 6, 45),
        ];
        
        // Динамический объект?
        dynamic dynamicObject = "not-a-triangle";
        dynamicObject = trianglesCollection[0];
        
        // Набор объектов (наверное тут имелся ввиду HashSet<T>)
        // По идее для корректной работы тут нужно переопределить метод GetHash()
        var uniqueTriangles = new HashSet<Triangle>(trianglesCollection);
        
        
        // Операторы
        var triangle = trianglesCollection[0];
        
        PrintHeader("Initial state");
        triangle.Show();
        
        PrintHeader("Sum");
        (triangle + triangle).Show();

        PrintHeader("Multiplication (10)");
        (triangle * 10).Show();
        
        PrintHeader("Pre-increment");
        (++triangle).Show();
        triangle.Show();
        
        PrintHeader("Post-increment");
        (triangle++).Show();
        triangle.Show();
        
        PrintHeader("Pre-subtraction");
        (--triangle).Show();
        triangle.Show();
        
        PrintHeader("Post-subtraction");
        (triangle--).Show();
        triangle.Show();
    }
    
    private static void PrintHeader(string text)
    {
        var decoration = new string('=', 10);
        Console.WriteLine($"\n{decoration}{text}{decoration}\n");
    }
}