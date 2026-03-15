namespace Task4.IndependentWork.Models;

internal sealed class CustomSortedSet<T>(int capacity) where T : IComparable<T>
{
    private readonly DynamicArray<T> _items = new(capacity);

    public CustomSortedSet() : this(0)
    {
    }

    public bool Add(T item)
    {
        var index = _items.BinarySearch(item);
        if (index >= 0)
        {
            return false;
        }
        
        // ~ для декодинга таргет индекса
        _items.Insert(~index, item);
        return true;
    }

    public bool Remove(T item)
    {
        var index = _items.BinarySearch(item);
        if (index < 0)
        {
            return false;
        }

        _items.RemoveAt(index);
        return true;
    }

    public bool Contains(T item)
    {
        return _items.BinarySearch(item) >= 0;
    }
}