namespace CleanList;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Unordered List:");
        UnorderedList<int> ul = new UnorderedList<int>();
        ul.Add(1);
        ul.Add(2);
        ul.Add(3);
        ul.Add(4);
        ul.Add(5);
        ul.Remove(2);
        ul.RemoveAt(3);
        
        Console.WriteLine(ul.ToString());
        Console.WriteLine(ul.Count);

        int[] arr = ul.ToArray();
        Console.WriteLine(string.Join(", ", arr));
        Console.WriteLine("==================");

        Console.WriteLine("Ordered List:");
        OrderedList<char> ol = new OrderedList<char>();
        ol.Add('b');
        ol.Add('x');
        ol.Add('c');
        ol.Add('a');
        ol.Add('f');
        
        Console.WriteLine(ol.ToString());
        Console.WriteLine(ol.Count);
        
        char[] arr1 = ol.ToArray();
        Console.WriteLine(string.Join(", ", arr1));
    }
}

