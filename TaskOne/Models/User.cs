namespace TaskOne.Models;

public abstract class User
{
    protected string Name { get; set; }
    protected byte Age { get; set; }
    
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
        Age = value;
    }

    public byte GetAge()
    {
        return Age;
    }

    public override string ToString()
    {
        return $"Пользователь {Name} с возрастом {Age}";
    }
}