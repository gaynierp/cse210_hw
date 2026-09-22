using System;

class Program
{
    static void Main(string[] args)
    {
        int x = 12;
        int y = 22;
        int z = 4;
        if (x == 10) {
            Console.WriteLine("X is 10");
            Console.WriteLine ("Y is fun");
        }
        else if (x == 5 || z == 4 && z ==5)
        {
            Console.WriteLine("Z = 4");
        }
        else if (x > 4 || y != 20)
        {
            Console.WriteLine("Print");
        }
        else {
            Console.WriteLine("Default output");
        }
    }
}