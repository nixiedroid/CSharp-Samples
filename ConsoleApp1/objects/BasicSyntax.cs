namespace ConsoleApp1.objects;

public class BasicSyntax
{
    private void Syntax()
    {
        Person p = new Person();
        p.DoWalk();
        Alex al = new Alex();
        al.DoWalk();
        int i = 4;
        while (i>=0)
        {
            Console.Write("i = " + i);
            i--;
            switch (i)
            {
                case 4:
                    Console.Write("FOUR");
                    break;
                case 3:
                    Console.Write("THREE");
                    break;
            }
        }

        List<Int32> list = new List<int>();
        list.Add(34);
        list.Add(31);
        
        IPrinter printer = new PrinterImpl();
        printer.Print(p);
        
        list.ForEach(l => Console.WriteLine(l));
        
        
        int anInt = 4;
        Console.WriteLine($"Value of int is : {anInt}");
        Console.WriteLine("Value of int is : " + anInt);    }
}