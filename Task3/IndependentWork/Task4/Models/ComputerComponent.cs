namespace Task3.IndependentWork.Task4.Models;

internal abstract class ComputerComponent
{
    private readonly string _manufacturer;

    protected ComputerComponent(string manufacturer)
    {
        Console.WriteLine($"{nameof(ComputerComponent)} constructor called.");

        _manufacturer = manufacturer;
    }

    public virtual void Print()
    {
        Console.WriteLine($"{nameof(ComputerComponent)}\n\tManufacturer:{_manufacturer}");
    }
}