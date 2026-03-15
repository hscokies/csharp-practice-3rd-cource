namespace Task4.IndependentWork.Models;

internal sealed class CustomQueue<T>(int capacity)
{
    // Предположу, что нельзя использовать встроенные типы, поэтому делаю через свою реализацию 
    private readonly DynamicArray<T> _items = new(capacity);

    public CustomQueue() : this(0)
    {
    }

    public void Enqueue(T item)
    {
        _items.Add(item);
    }

    // Наверное, в идеальном мире это нужно делать через переменную-указатель, по аналогии с _size в DynamicArray<T>
    public T Dequeue()
    {
        ThrowIfEmpty();
        
        var item = _items[0];
        _items.RemoveAt(0);
        
        return item;
    }

    public T Peek()
    {
        ThrowIfEmpty();
        
        return _items[0];
    }
    
    private void ThrowIfEmpty()
    {
        if (_items.IsEmpty)
        {
            throw new InvalidOperationException($"{nameof(CustomQueue<>)} is empty");
        }
    }
}