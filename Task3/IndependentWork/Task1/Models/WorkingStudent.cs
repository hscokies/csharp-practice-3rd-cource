namespace Task3.IndependentWork.Task1.Models;

public class WorkingStudent(string fullName, string university, byte year, string workplace) : Student(fullName, university, year)
{
    public string Workplace { get; } = workplace;

    public override void Print()
    {
        base.Print();
        Console.WriteLine($"{nameof(WorkingStudent)}\n\t{nameof(Workplace)}:{Workplace}");
    }
}