namespace Task4.IndependentWork.Models;

internal sealed class CustomLinkedList<T>
{
    private Node? _head;

    private Node? _tail;
    
    public T First()
    {
        return _head is null ?  throw new InvalidOperationException() : _head.Value;
    }

    public T Last()
    {
        return _tail is null ?  throw new InvalidOperationException() : _tail.Value;
    }
    

    public void AddFirst(T value)
    {
        var node = new Node(value);
        if (_head is null)
        {
            _head = node;
            _tail = node;
            node.Next = null;
            node.Previous = null;
        }
        else
        {
            node.Next = _head;
            node.Previous = null;
            _head.Previous = node;
            _head = node;
        }
    }

    public void AddLast(T value)
    {
        var node = new Node(value);
        if (_head is null)
        {
            _head = node;
            _tail = node;
            node.Next = null;
            node.Previous = null;
        }
        else
        {
            node.Previous = _tail;
            node.Next = null;
            _tail!.Next = node;
            _tail = node;
        }
    }

    public void RemoveFirst()
    {
        if (_head is null)
        {
            throw new InvalidOperationException($"{nameof(CustomLinkedList<>)} is empty");
        }
        
        if (_head == _tail)
        {
            _head = null;
            _tail = null;
        }
        else
        {
            _head = _head!.Next;
            _head!.Previous = null;
        }
    }

    public void RemoveLast()
    {
        if (_tail is null)
        {
            throw new InvalidOperationException("tail is empty");
        }

        if (_head == _tail)
        {
            _head = null;
            _tail = null;
        }
        else
        {
            _tail = _tail.Previous;
            _tail!.Next = null;
        }
    }

    private void Remove(Node node)
    {
        if (node == _head)
        {
            RemoveFirst();
            return;
        }

        if (node == _tail)
        {
            RemoveLast();
            return;
        }

        node.Previous!.Next = node.Next;
        node.Next!.Previous = node.Previous;
        node.Invalidate();
    }


    private record Node(T Value)
    {
        public Node? Next { get; internal set; }
        public Node? Previous { get; internal set; }

        internal void Invalidate()
        {
            Next = null;
            Previous = null;
        }
    }
}