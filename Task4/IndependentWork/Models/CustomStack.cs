namespace Task4.IndependentWork.Models;

internal sealed class CustomStack<T>(int capacity)
{
    private readonly DynamicArray<T> _items = [];

    public CustomStack() : this(0)
    {
    }
    
    public void Push(T item)
    {
        _items.Add(item);
    }

    public T Pop()
    {
        var item = Peek();
        _items.RemoveAt(^1);
        
        return item;
    }

    public T Peek()
    {
        ThrowIfEmpty();
        return _items[^1];
    }
    
    private void ThrowIfEmpty()
    {
        if (_items.Count is 0)
        {
            throw new InvalidOperationException($"{nameof(CustomStack<>)} is empty");
        }
    }
}