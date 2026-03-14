namespace Task3.IndependentWork.Task1.Models;

public abstract class Learner(string fullName)
{
    public string FullName { get; } = fullName;

    public virtual void Print()
    {
        Console.WriteLine($"{nameof(Learner)}:\n\t{nameof(FullName)}:{FullName}");
    }
}