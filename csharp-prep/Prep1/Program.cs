using System;

class Program
{
    static void Main(string[] args)
    {
        string firstName;
        string lastName;
        Console.Write("Please enter your name: ");
        firstName = Console.ReadLine();
        Console.WriteLine("Please enter you last name");
        lastName = Console.ReadLine();
        Console.WriteLine($"{firstName} {lastName}");
    }
}