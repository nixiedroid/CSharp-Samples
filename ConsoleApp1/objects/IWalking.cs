namespace ConsoleApp1.objects;

public interface IWalking
{
    void Walk();

    static void Walks()
    {
        Console.WriteLine("walks");
    }
}