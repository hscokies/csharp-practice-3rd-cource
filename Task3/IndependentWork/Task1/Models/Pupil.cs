namespace Task3.IndependentWork.Task1.Models;

public class Pupil(string fullName, byte grade) : Learner(fullName)
{
    public byte Grade { get; } = grade;

    public override void Print()
    {
        base.Print();
        Console.WriteLine($"{nameof(Pupil)}:\n\t{nameof(Grade)}:{Grade}");
    }
}