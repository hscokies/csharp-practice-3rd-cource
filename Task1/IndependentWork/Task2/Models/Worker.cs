namespace Task1.IndependentWork.Task2.Models;

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
        if (CheckAge(value))
        {
            _age = value;
        }
    }

    public decimal GetSalary()
    {
        return _salary;
    }

    public void SetSalary(decimal value)
    {
        _salary = value;
    }

    private static bool CheckAge(byte age)
    {
        return age is >= 1 and <= 100;
    }

    public override string ToString()
    {
        return $"{nameof(Worker)}:\n\tName:{_name}\n\tAge:{_age}\n\tSalary:{_salary}";
    }
}