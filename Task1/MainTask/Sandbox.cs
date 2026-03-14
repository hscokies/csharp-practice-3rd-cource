using Task1.MainTask.Models;

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
        Console.WriteLine(triangle);
        
        PrintHeader("Sum");
        Console.WriteLine(triangle + triangle);

        PrintHeader("Multiplication (10)");
        Console.WriteLine(triangle * 10);
        
        PrintHeader("Pre-increment");
        Console.WriteLine(++triangle);
        Console.WriteLine(triangle);
        
        PrintHeader("Post-increment");
        Console.WriteLine(triangle++);
        Console.WriteLine(triangle);
        
        PrintHeader("Pre-subtraction");
        Console.WriteLine(--triangle);
        Console.WriteLine(triangle);
        
        PrintHeader("Post-subtraction");
        Console.WriteLine(triangle--);
        Console.WriteLine(triangle);
    }
    
    private static void PrintHeader(string text)
    {
        var decoration = new string('=', 10);
        Console.WriteLine($"\n{decoration}{text}{decoration}\n");
    }
}