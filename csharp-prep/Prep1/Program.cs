using System;

class Program
{
    static void Main(string[] args)
    {
        // C# is strongly typed. Set variables before you can use it
        // also you can't change data type
        string firstName;
        string lastName;
        // .Write enters input on the same line
        Console.Write("Please enter your name: ");
        firstName = Console.ReadLine();
        // .WriteLine enters input on a new line
        Console.WriteLine("Please enter your last name: ");
        lastName = Console.ReadLine();
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}");
    }
}