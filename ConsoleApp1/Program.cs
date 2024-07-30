namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Person p = new Person();
        p.DoWalk();
        A a = new A();
        Console.WriteLine(a.GetType().FullName);
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
        list.Add(24);
        Console.WriteLine(Printer.print(list));

    }

    abstract class Printer
    {
        static public string print<T>(T obj)
        {
            return obj.ToString();
        }
    }

    class A
    {
    }
}