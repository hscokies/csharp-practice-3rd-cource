namespace Task1.IndependentWork.Task1.Models;

internal sealed class Worker
{
    private string _name;
    private byte _age;
    private decimal _salary;


    public string GetName()
    {
        return _name;
    }
    public void SetName(string value)
    {
        _name = value;
    }

    public byte GetAge()
    {
        return _age;
    }
    public void SetAge(byte value)
    {
        _age = value;
    }
    
    public decimal GetSalary()
    {
        return _salary;
    }
    public void SetSalary(decimal value)
    {
        _salary = value;
    }
}