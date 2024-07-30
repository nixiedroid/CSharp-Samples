namespace ConsoleApp1.objects;

public class NameReader
{
    static public void ReadAndPrintName()
    {
        Console.Write("Введите ваше имя: ");
        var name = Console.ReadLine();
        Console.WriteLine("Вас зовут: " + name);
    }
    
}