namespace CleanList;

public class UnorderedList<T>
{
    private readonly Node<T> _head;
    
    public int Count { get; private set; }

    public UnorderedList()
    {
        _head = new Node<T>(default!, null!);
    }

    public void Add(T value)
    {
        Node<T> node = _head;

        while (node.Next is not null)
        {
            node = node.Next;
        }

        Count++;
        node.Next = new Node<T>(value, null);
    }

    public bool Remove(T value)
    {
        Node<T> node = _head;

        while (node.Next is not null && !node.Next.Value.Equals(value))
        {
            node = node.Next;
        }

        if (node.Next is null)
            return false;

        Node<T> pointer = node.Next.Next;
        node.Next = pointer;
        Count--;
        return true;
    }
    
    public bool RemoveAt(int index)
    {
        int currentIndex = 0;
        Node<T> node = _head;

        while (node.Next is not null && index > currentIndex + 1)
        {
            node = node.Next;
            currentIndex++;
        }

        if (node.Next is null)
            return false;

        Node<T> pointer = node.Next.Next;
        node.Next = pointer;
        Count--;
        return true;
    }

    public T[] ToArray()
    {
        Node<T> node = _head;
        T[] arr = new T[Count];
        int i = 0;
        
        while (node.Next is not null)
        {
            node = node.Next;
            arr[i] = node.Value;
            i++;
        }

        return arr;
    }

    public override string ToString()
    {
        Node<T> node = _head;
        string str = string.Empty;
        
        while (node.Next is not null)
        {
            node = node.Next;
            str += node.Value.ToString();
            str += "\n";
        }

        return str;
    }
}