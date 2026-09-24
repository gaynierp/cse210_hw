using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        List<int> numbers = new List<int> {};
        int num;
        do
        {
            Console.WriteLine("Enter a number: ");
            num = int.Parse(Console.ReadLine());
            if (num != 0)
            {
                numbers.Add(num);
            }
        } while (num != 0);
        int sum = numbers.Sum();
        float avg = sum / numbers.Count;
        int high = 0;

        foreach(int nu in numbers)
        {
            if (nu > high)
            {
                high = nu;
            }
        }
        Console.WriteLine($"Sum of the list {sum}, average of the list: {avg}, highest number in the list {high}");
    }
}