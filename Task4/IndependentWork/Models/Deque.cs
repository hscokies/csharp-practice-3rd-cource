namespace Task4.IndependentWork.Models;

internal sealed class Deque<T>
{
    private int _count;
    public bool IsEmpty => _count is 0;


    private Node? _head;
    private Node? _tail;


    public T First()
    {
        return IsEmpty ? throw new InvalidOperationException() : _head!.Value;
    }

    public T Last()
    {
        return IsEmpty ? throw new InvalidOperationException() : _tail!.Value;
    }

    public void AddFirst(T item)
    {
        var node = new Node(item);
        if (IsEmpty)
        {
            _head = _tail = node;
        }
        else
        {
            node.Next = _head;
            _head!.Previous = node;
            _head = node;
        }

        _count++;
    }

    public void AddLast(T item)
    {
        var newNode = new Node(item);

        if (IsEmpty)
        {
            _head = _tail = newNode;
        }
        else
        {
            newNode.Previous = _tail;
            _tail!.Next = newNode;
            _tail = newNode;
        }

        _count++;
    }

    public T RemoveFirst()
    {
        if (_head is null)
        {
            throw new InvalidOperationException($"{nameof(Deque<>)} is empty");
        }

        var value = _head.Value;
        _head = _head.Next;

        if (_head != null)
        {
            _head.Previous = null;
        }
        else
        {
            _tail = null;
        }

        _count--;
        return value;
    }

    public T RemoveLast()
    {
        if (_tail is null)
        {
            throw new InvalidOperationException("tail is empty");
        }

        var value = _tail.Value;
        _tail = _tail.Previous;

        if (_tail is not null)
        {
            _tail.Next = null;
        }
        else
        {
            _head = null;
        }

        _count--;
        return value;
    }

    private sealed class Node(T value)
    {
        public T Value { get; } = value;
        public Node? Previous { get; set; }
        public Node? Next { get; set; }
    }
}