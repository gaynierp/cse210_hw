using System;

class Program
{
    static void Main(string[] args)
    {
        int grade;
        string letter = "";
        Console.WriteLine("What grade did you get? Just type the number like 99");
        grade = int.Parse(Console.ReadLine());
        if (grade > 90)
        {
            letter = "A";
        }
        else if (grade > 80)
        {
            letter = "B";
        }
        else if (grade > 70)
        {
            letter = "C";
        }
        else if (grade > 60)
        {
            letter = "D";
        }
        else if (grade < 60)
        {
            letter = "F";
        }


        if (letter == "C" || letter == "B" || letter == "A")
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("You didn't pass but try again!");
        }
        }
    }