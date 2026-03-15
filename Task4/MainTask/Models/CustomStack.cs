namespace Task4.MainTask.Models;

internal sealed class CustomStack<T>
{
    private readonly List<T> _items = [];

    public void Push(T item)
    {
        _items.Add(item);
    }
    
    public T Pop()
    {
        var item = Peek();
        _items.Remove(item);
        
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