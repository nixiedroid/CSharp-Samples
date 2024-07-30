namespace ConsoleApp1.objects;

public abstract class Animal : IWalking
{
    public void Walk()
    {
        DoWalk();
    }

    public abstract void DoWalk();
}