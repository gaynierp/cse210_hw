using System;
class Program
{
    static void Main(string[] args)
    {
        Circle myCircle = new Circle(1000);
        double area = myCircle.GetArea();
        Console.WriteLine(area);
    }
}

