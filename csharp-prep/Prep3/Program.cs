using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        Random rg = new Random();
        int num = rg.Next(1, 100);
        int guess = 0;
        while (guess != num)
        {
            Console.WriteLine("What is your guess: ");
            guess = int.Parse(Console.ReadLine());
            if (guess < num)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > num)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("Good job!");
            }

        }

    }
}