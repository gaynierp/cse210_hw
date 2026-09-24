using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");
        DisplayResult();
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.WriteLine("What is your name? ");
        return Console.ReadLine();
    }

    static int PromptUserNumber()
    {
        Console.WriteLine("What is your favorite number?");
        return int.Parse(Console.ReadLine());
    }

    static void PromptUserBirthYear(out int year)
    {
        Console.WriteLine("What is your brith year? ");
        year = int.Parse(Console.ReadLine());
        
    }

    static int SquareNumber(int number)
    {
        return number * number;
    }

    static void DisplayResult()
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int age;
        PromptUserBirthYear(out age);
        Console.WriteLine(SquareNumber(number));
        Console.WriteLine($"You will be {2026 - age} this year");

    }

}