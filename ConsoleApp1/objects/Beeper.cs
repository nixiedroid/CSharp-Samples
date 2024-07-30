namespace ConsoleApp1.objects;

public class Beeper
{
    public static void Beep()
    {
        
        Console.Beep(440,300);
        Thread.Sleep(100);
        Console.Beep(880,300);
        Thread.Sleep(100);
        Console.Beep(440,300);
        Thread.Sleep(100);
        Console.Beep(880,300);
        Thread.Sleep(100);
        Console.Beep(440,300);
        Thread.Sleep(100);
        Console.Beep(440,300);
        Thread.Sleep(100);
        Console.Beep(220,300);
        Thread.Sleep(100);
    }
}