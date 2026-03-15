namespace Task4.IndependentWork.Models;

internal sealed class CustomCircularLinkedList<T>
{
    private Node? _head;

    public T First()
    {
        return _head is null ?  throw new InvalidOperationException() : _head!.Value;
    }

    public T Last()
    {
        return _head?.Previous is null ?  throw new InvalidOperationException() : _head.Previous.Value;
    }

    public void AddFirst(T value)
    {
        var node = new Node(value, this);

        if (_head is null)
        {
            node.Previous = node.Next = node;
        }
        else
        {
            InsertBefore(_head, node);
        }

        _head = node;
    }

    public void AddLast(T value)
    {
        var node = new Node(value, this);

        if (_head is null)
        {
            node.Previous = node.Next = node;
            _head = node;
        }
        else
        {
            InsertBefore(_head, node);
        }
    }


    public void RemoveFirst()
    {
        if (_head is null)
        {
            throw new InvalidOperationException($"{nameof(CustomCircularLinkedList<>)} is empty");
        }

        Remove(_head);
    }

    public void RemoveLast()
    {
        if (_head?.Previous is null)
        {
            throw new InvalidOperationException($"{nameof(CustomCircularLinkedList<>)} is empty");
        }
        
        Remove(_head.Previous);
    }

    private void Remove(Node node)
    {
        ArgumentNullException.ThrowIfNull(node);

        if (node.List != this)
        {
            throw new InvalidOperationException($"{nameof(CustomCircularLinkedList<>)} mismatch");
        }

        if (node.Next == node)
        {
            _head = null;
        }
        else
        {
            node.Previous!.Next = node.Next;
            node.Next!.Previous = node.Previous;

            if (_head == node)
            {
                _head = node.Next;
            }
        }

        node.Invalidate();
    }

    private static void InsertBefore(Node node, Node newNode)
    {
        newNode.Next = node;
        newNode.Previous = node.Previous;
        node.Previous!.Next = newNode;
        node.Previous = newNode;
    }

    private class Node(T value, CustomCircularLinkedList<T> list)
    {
        internal Node? Next;
        internal Node? Previous;
        public T Value => value;

        internal CustomCircularLinkedList<T>? List { get; private set; } = list;

        internal void Invalidate()
        {
            List = null;
            Next = null;
            Previous = null;
        }
    }
}