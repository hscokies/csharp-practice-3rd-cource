using System.Collections;
using System.Runtime.CompilerServices;

namespace Task4.IndependentWork.Models;

internal sealed class DynamicArray<T>(int capacity) : IEnumerable<T>
{
    public int Count => _size;

    public bool IsEmpty => _size == 0;
    
    private T[] _items = new T[capacity];
    private int _size;

    public DynamicArray() : this(0)
    {
    }
    
    public T this[int index]
    {
        get => index >= _size ? throw new ArgumentOutOfRangeException(nameof(index)) : _items[index];
        set
        {
            ArgumentOutOfRangeException.ThrowIfGreaterThanOrEqual(index, _size);
            _items[index] = value;
        }
    }

    public void Add(T item)
    {
        if (_size >= _items.Length)
        {
            Array.Resize(ref _items, _items.Length + 1);
        }

        _items[_size] = item;
        _size++;
    }

    public void Insert(int index, T item)
    {
        if (index > _size)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }
        
        if (_size == _items.Length)
        {
            GrowForInsertion(index, 1);
        }
        else if (index < _size)
        {
            Array.Copy(_items, index, _items, index + 1, _size - index);
        }
        _items[index] = item;
        _size++;
    }

    public bool Remove(T item)
    {
        var index = _items.IndexOf(item);
        if (index is -1)
        {
            return false;
        }

        return RemoveAt(index);
    }

    public bool RemoveAt(Index index)
    {
        var indexNormalized = index.Value;
        if (index.IsFromEnd)
        {
            indexNormalized = _items.Length - index.Value;
        }


        _size--;
        if (indexNormalized < _size)
        {
            Array.Copy(_items, indexNormalized + 1, _items, indexNormalized, _size - indexNormalized);
        }

        if (RuntimeHelpers.IsReferenceOrContainsReferences<T>())
        {
            _items[_size] = default!;
        }
        
        return true;
    }
    
    private void GrowForInsertion(int indexToInsert, int insertionCount = 1)
    {
        var capacity = _size + insertionCount;
        var newItems = new T[capacity];
        if (indexToInsert != 0)
        {
            Array.Copy(_items, newItems, length: indexToInsert);
        }

        if (_size != indexToInsert)
        {
            Array.Copy(_items, indexToInsert, newItems, indexToInsert + insertionCount, _size - indexToInsert);
        }

        _items = newItems;
    }
    
    public int BinarySearch(T item) => BinarySearch(0, Count, item, null);

    public int BinarySearch(T item, IComparer<T>? comparer) => BinarySearch(0, Count, item, comparer);

    public int BinarySearch(int index, int count, T item, IComparer<T>? comparer = null) =>
        Array.BinarySearch(_items, index, count, item, comparer);

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    public IEnumerator<T> GetEnumerator()
    {
        for (var i = 0; i < _size; i++)
        {
            yield return _items[i];
        }
    }
}