namespace Task3.IndependentWork.Task1.Models;

public class Student(string fullName, string university, byte year) : Learner(fullName)
{
    public string University { get; } = university;
    public byte Year { get; } = year;
    
    public override void Print()
    {
        base.Print();
        Console.WriteLine($"{nameof(Student)}:\n\t{nameof(University)}:{University}\n\t{nameof(Year)}:{Year}");
    }
}