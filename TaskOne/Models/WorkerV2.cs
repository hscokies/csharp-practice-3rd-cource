namespace TaskOne.Models;

public class WorkerV2 
{
    private string Name { get; set; }
    private byte Age { get; set; }
    private decimal Salary { get; set; }


    public void SetName(string value)
    {
        Name = value;
    }

    public string GetName()
    {
        return Name;
    }

    public void SetAge(byte value)
    {
        if (CheckAge(value))
        {
            Age = value;
        }
    }

    public byte GetAge()
    {
        return Age;
    }

    public void SetSalary(decimal value)
    {
        Salary = value;
    }

    public decimal GetSalary()
    {
        return Salary;
    }
    
    private static bool CheckAge(byte age)
    {
        return age is >= 1 and <= 100;
    }

    public override string ToString()
    {
        return $"{Name} {Age} {Salary} RUB";
    }
}