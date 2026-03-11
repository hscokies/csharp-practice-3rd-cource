using System.Diagnostics;
using TaskOne.Models;

namespace TaskOne;

public static class WorkerDemo
{
    public static void First()
    {
        PrintHeader("Первое задание");
        var ivan = new WorkerV1();
        ivan.SetName("Иван");
        ivan.SetAge(25);
        ivan.SetSalary(10_000);
        
        var vasya = new WorkerV1();
        vasya.SetName("Василий");
        vasya.SetAge(26);
        vasya.SetSalary(20_000);
        
        var salariesSum = ivan.GetSalary() + vasya.GetSalary();
        Console.WriteLine($"Сумма зарплат {ivan.GetName()} и {vasya.GetName()} равна {salariesSum}");
        
        var agesSum = ivan.GetAge() + vasya.GetAge();
        Console.WriteLine($"Сумма возрастов {ivan.GetName()} и {vasya.GetName()} равна {agesSum}");
    }

    public static void Second()
    {
        PrintHeader("Второе задание");
        var worker = new WorkerV2();
        worker.SetName("Иван");
        worker.SetAge(25);
        worker.SetSalary(10_000);
        
        Console.WriteLine(worker);
        
        worker.SetAge(101);
        Debug.Assert(worker.GetAge() != 101);
        Console.WriteLine(worker);
        
        worker.SetAge(35);
        Debug.Assert(worker.GetAge() == 35);
        Console.WriteLine(worker);
    }

    public static void Third()
    {
        PrintHeader("Задачи 3-6");
        ICollection<User> users =
        [
            new WorkerV3(),
            new Student(),
            new Driver()
        ];
        
        foreach (var user in users)
        {
            Console.WriteLine(user);
        }
    }
    
    private static void PrintHeader(string text)
    {
        var decoration = new string('=', 10);
        Console.WriteLine($"\n{decoration}{text}{decoration}\n");
    }
}