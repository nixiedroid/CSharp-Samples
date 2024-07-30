namespace ConsoleApp1.objects;

public class ArraySorter
{
    private static Random _r = new Random();
    private static int[] _array;

    private static void GenerateArray(uint size)
    {
        _array = new int[size];
        for (int i = 0; i < _array.Length; i++)
        {
            _array[i] = _r.Next()%100;
        }
    }

    private static void SortArray()
    {
      Array.Sort(_array);
    }

    private static void PrintArray()
    {
        foreach (var i in _array)
        {
            Console.Write(i + ", ");
        }
        Console.WriteLine();
    }

    public static void DoWork()
    {
        GenerateArray(10);
        PrintArray();
        SortArray();
        PrintArray();
    }
}