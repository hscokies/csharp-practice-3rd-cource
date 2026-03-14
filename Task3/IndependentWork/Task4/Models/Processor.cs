namespace Task3.IndependentWork.Task4.Models;

internal abstract class Processor : ComputerComponent
{
    public abstract void ExecuteInstruction();

    protected double ClockSpeed;
    private readonly byte _cores;

    protected Processor(double clockSpeed, byte cores, string manufacturer) : base(manufacturer)
    {
        Console.WriteLine($"{nameof(Processor)} constructor called.");
        
        ClockSpeed = clockSpeed;
        _cores = cores;
    }
    
    public override void Print()
    {
        base.Print();
        Console.WriteLine($"{nameof(Processor)}\n\tClock speed:{ClockSpeed}\n\tCores:{_cores}");
    }

}