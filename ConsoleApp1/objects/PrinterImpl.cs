namespace ConsoleApp1.objects;

public class PrinterImpl : IPrinter
{
    
    public void Print<T>(T obj)
    {
        Console.WriteLine(obj);
        Console.WriteLine(obj.ToString());
    }
}