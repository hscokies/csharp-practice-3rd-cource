namespace Task4.MainTask.Models;

internal sealed class CustomStack<T>
{
    private readonly List<T> _items = [];
    private Index Pointer => _items.Count > 0 ? new Index(1, true) :  throw new InvalidOperationException($"{nameof(CustomStack<>)} is empty");

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
        return _items[Pointer];
    }
}