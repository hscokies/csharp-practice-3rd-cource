namespace Task4.IndependentWork.Models;

internal sealed class BinaryTree<T> where T : IComparable<T>
{
    public Node? Root { get; private set; }

    public void Add(T value)
    {
        if (Root is null)
        {
            Root = new Node(value);
            return;
        }

        var current = Root;

        do
        {
            var comparisonResult = value.CompareTo(current!.Value);
            if (comparisonResult is 0)
            {
                current.Instances++;
                return;
            }

            var node = new Node(value)
            {
                Parent = current
            };

            if (comparisonResult > 0)
            {
                if (!current.HasRight)
                {
                    current.Right = node;
                    return;
                }

                current = current.Right;
            }
            else
            {
                if (!current.HasLeft)
                {
                    current.Left = node;
                    return;
                }

                current = current.Left;
            }
        } while (true);
    }

    public bool Remove(T value)
    {
        var node = Find(value, Root);
        if (node is null)
        {
            return false;
        }

        if (node.Instances > 1)
        {
            node.Instances--;
            return true;
        }

        Remove(node);
        return true;
    }

    private void Remove(Node node)
    {
        var hasMore = true;
        do
        {
            if (node is { HasLeft: false, HasRight: false })
            {
                Replace(node, null);
            }
            else if (!node.HasLeft)
            {
                Replace(node, node.Right);
            }
            else if (!node.HasRight)
            {
                Replace(node, node.Left);
            }
            else
            {
                var successor = FindLeftMost(node.Right!);
                node.Value = successor.Value;
                node.Instances = successor.Instances;

                node = successor;
                continue;
            }

            hasMore = false;
        } while (hasMore);
    }

    private void Replace(Node old, Node? newNode)
    {
        newNode?.Parent = old.Parent;

        if (old.IsRoot)
        {
            Root = newNode;
        }
        else if (old.IsLeft)
        {
            old.Parent!.Left = newNode;
        }
        else
        {
            old.Parent!.Right = newNode;
        }
    }


    private static Node? Find(T value, Node? current)
    {
        while (current is not null)
        {
            var comparison = value.CompareTo(current.Value);
            if (comparison is 0)
            {
                return current;
            }

            current = comparison < 0 ? current.Left : current.Right;
        }

        return null;
    }

    private static Node FindLeftMost(Node node)
    {
        while (node.HasLeft)
        {
            node = node.Left!;
        }

        return node;
    }

    public void Print()
    {
        PrintTree(Root);
    }
    
    private static void PrintTree(Node? node, int indentSize = 0)
    {
        if (node is null)
        {
            return;
        }

        var prefix = node.IsRoot ? "+" : node.IsLeft ? "L" : "R";
            
        Console.WriteLine($"{new string(' ', indentSize)} [{prefix}]: {node.Value} ({node.Instances})");
        indentSize += 3;


        PrintTree(node.Left, indentSize);
        PrintTree(node.Right, indentSize);
    }

    internal sealed class Node(T value)
    {
        public T Value { get; internal set; } = value;

        public uint Instances { get; internal set; } = 1;

        public Node? Parent { get; internal set; }
        public Node? Left { get; internal set; }
        public Node? Right { get; internal set; }

        public bool HasLeft => Left is not null;
        public bool HasRight => Right is not null;
        public bool IsRoot => Parent is null;
        public bool IsLeft => this == Parent?.Left;
        public bool IsRight => this == Parent?.Right;
    }
}