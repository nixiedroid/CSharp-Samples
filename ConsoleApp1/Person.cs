namespace ConsoleApp1;

public class Person : IWalking
{
    private bool isWalking;
    private static  string name = "Alex";
    
    public Person()
    {
        isWalking = false;
    }

    public virtual void DoWalk()
    {
        Console.WriteLine("I am Walking");
        isWalking = true;
    }
}