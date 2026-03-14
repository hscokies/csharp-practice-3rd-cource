namespace Task3.IndependentWork.Task4.Models;

internal sealed class Gpu : Processor
{
    private readonly double _vMemory;

    public Gpu(double vMemory, double clockSpeed, byte cores, string manufacturer) : base(clockSpeed, cores, manufacturer)
    {
        Console.WriteLine($"{nameof(Gpu)} constructor called.");
        
        _vMemory = vMemory;
    }


    public override void ExecuteInstruction() => Console.WriteLine("Rendering graphic...");
    public void ProcessShaders(int shaderCount) => Console.WriteLine($"Processing {shaderCount} shaders...");
    
    
    public override void Print()
    {
        base.Print();
        Console.WriteLine($"{nameof(Gpu)}\n\tVMemory:{_vMemory}");
    }
}