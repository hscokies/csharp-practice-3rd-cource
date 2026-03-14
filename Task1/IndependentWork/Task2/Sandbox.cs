using Task1.IndependentWork.Task2.Models;

namespace Task1.IndependentWork.Task2;

internal static class Sandbox
{
    public static void Main()
    {
        var worker = new Worker();
        worker.SetName("Ivan");
        worker.SetAge(25);
        worker.SetSalary(10_000);
        
        Console.WriteLine(worker);
        
        worker.SetAge(0);
        Console.WriteLine(worker);
        
        worker.SetAge(101);
        Console.WriteLine(worker);
        
        worker.SetAge(100);
        Console.WriteLine(worker);
    }
}