namespace Task3.IndependentWork.Task4.Models;

internal sealed class Ram : ComputerComponent
{
    private readonly byte _capacity;

    public Ram(byte capacity, string manufacturer) : base(manufacturer)
    {
        _capacity = capacity;

        Console.WriteLine($"{nameof(Cpu)} constructor called.");
    }

    public void LoadData(byte[] data)
    {
        if (data.Length > _capacity)
        {
            throw new OutOfMemoryException();
        }
    }
    

    public override void Print()
    {
        base.Print();
        Console.WriteLine($"{nameof(Ram)}\n\tCapacity: {_capacity}");
    }
}