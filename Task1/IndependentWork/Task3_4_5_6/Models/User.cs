namespace Task1.IndependentWork.Task3_4_5_6.Models;

internal class User
{
    protected string Name;
    protected byte Age;
    
    public string GetName() => Name;
    public void SetName(string value) => Name = value;

    public byte GetAge() => Age;

    public void SetAge(byte value) => Age = value;

    public override string ToString()
    {
        return $"{nameof(User)}\n\tName:{Name}\n\tAge:{Age}";
    }
}