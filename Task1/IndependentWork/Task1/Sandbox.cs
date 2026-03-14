using Task1.IndependentWork.Task1.Models;

namespace Task1.IndependentWork.Task1;

internal static class Sandbox
{
    public static void Main()
    {
        var worker1 = new Worker();
        worker1.SetName("Ivan");
        worker1.SetAge(25);
        worker1.SetSalary(10_000);
        
        var worker2 = new Worker();
        worker2.SetName("Vasily");
        worker2.SetAge(26);
        worker2.SetSalary(20_000);
        
        //  Выведите на экран сумму зарплат Ивана и Василия.
        Console.WriteLine($"Salaries sum: {worker1.GetSalary()+worker2.GetSalary()}");
        
        // Выведите на экран сумму возрастов Ивана и Василия.
        Console.WriteLine($"Ages sum: {worker1.GetAge()+worker2.GetAge()}");
    }
}