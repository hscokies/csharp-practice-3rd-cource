using Task1.IndependentWork.Task3_4_5_6.Models;

namespace Task1.IndependentWork.Task3_4_5_6;

internal static class Sandbox
{
    public static void Main()
    {
        var user = new User();
        user.SetName("John");
        user.SetAge(15);
        Console.WriteLine(user);
        Console.WriteLine(new string('=', 50));
        
        var worker = new Worker();
        worker.SetName("Jim");
        worker.SetAge(26);
        worker.SetSalary(10_000);
        Console.WriteLine(worker);
        Console.WriteLine(new string('=', 50));
        
        var student = new Student();
        student.SetName("Jane");
        student.SetAge(21);
        student.SetYear(3);
        student.SetStipend(5_000);
        Console.WriteLine(student);
        Console.WriteLine(new string('=', 50));
        
        var driver = new Driver();
        driver.SetName("Jack");
        driver.SetAge(55);
        driver.SetExperience(20);
        driver.SetLicenseCategory(LicenseCategory.B);
        Console.WriteLine(driver);
    }
}