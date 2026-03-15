using Task4.IndependentWork.Models;

namespace Task4.IndependentWork;

internal static class Sandbox
{
    public static void Main()
    {
        // DynamicArray();
        // LinkedList();
        // CircularLinkedList();
        // BinaryTree();
        // Queue();
        // Stack();
        // Deque();
        // SortedSet();
        SparseArray();
    } 


    private static void DynamicArray()
    {
        var dynamicArr = new DynamicArray<int>(1)
        {
            1,
            2
        };

        dynamicArr.Remove(1);
        dynamicArr.Add(3);
        dynamicArr.Add(1);
        dynamicArr.RemoveAt(^2);
        
        foreach (var item in dynamicArr)
        {
            Console.WriteLine(item);
        }
    }
    
    private static void LinkedList()
    {
        var linkedList = new CustomLinkedList<int>();
        linkedList.AddFirst(2);
        linkedList.AddFirst(1);
        linkedList.AddLast(3);
        linkedList.RemoveFirst();
        linkedList.RemoveLast();
    }
    
    private static void CircularLinkedList()
    {
        var circularLinkedList = new CustomCircularLinkedList<int>();
        circularLinkedList.AddFirst(2);
        circularLinkedList.AddFirst(1);
        circularLinkedList.AddLast(3);
        circularLinkedList.RemoveFirst();
    }
    
    private static void BinaryTree()
    {
        var binaryTree = new BinaryTree<int>();
        binaryTree.Add(50);
        binaryTree.Add(30);
        binaryTree.Add(70);
        binaryTree.Add(30);
        binaryTree.Add(20);
        binaryTree.Add(40);
        binaryTree.Add(80);
        binaryTree.Add(75);
        binaryTree.Add(80);
        
        // Через Debugger слишком запарно было проверять, поэтому добавил вывод
        binaryTree.Print();
        Console.WriteLine(new string('-', 50));
        binaryTree.Remove(30);
        binaryTree.Remove(70);
        binaryTree.Print();
    }

    private static void Stack()
    {
        var stack = new CustomStack<int>();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        

        Console.WriteLine(stack.Peek());
        Console.WriteLine(stack.Pop());

        Console.WriteLine(stack.Pop());
    }

    private static void Queue()
    {
        var queue = new CustomQueue<int>(30);
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        

        Console.WriteLine(queue.Peek());
        Console.WriteLine(queue.Dequeue());

        Console.WriteLine(queue.Dequeue());
    }

    private static void Deque()
    {
        var deque = new Deque<int>();
        deque.AddFirst(1);
        deque.AddLast(3);
        deque.AddLast(2);
        
        deque.RemoveFirst();
        deque.RemoveLast();
    }

    private static void SortedSet()
    {
        var sortedSet = new CustomSortedSet<int>();
        sortedSet.Add(2);
        sortedSet.Add(1);
        sortedSet.Add(4);
        // sortedSet.Add(1);
        // sortedSet.Remove(-1);
        sortedSet.Remove(1);
    }

    private static void SparseArray()
    {
        var sparseArray = new SparseArray<int>();
        sparseArray[0] = 1;
        sparseArray[1] = 0;
    }
}