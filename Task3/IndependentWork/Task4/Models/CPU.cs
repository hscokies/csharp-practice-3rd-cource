namespace Task3.IndependentWork.Task4.Models;

internal sealed class Cpu : Processor
{
    private readonly InstructionsSet _instructionsSet;

    public Cpu(InstructionsSet instructionsSet, double clockSpeed, byte cores, string manufacturer) : base(clockSpeed, cores, manufacturer)
    {
        Console.WriteLine($"{nameof(Cpu)} constructor called.");

        _instructionsSet = instructionsSet;
    }

    public override void ExecuteInstruction() => Console.WriteLine("Handling multiple tasks...");

    public void Overclock(double modifier)
    {
        ClockSpeed *= modifier;
    }

    public override void Print()
    {
        base.Print();
        Console.WriteLine($"{nameof(Processor)}\n\tISA:{_instructionsSet}");
    }
}

internal enum InstructionsSet
{
    X86,
    Arm,
}