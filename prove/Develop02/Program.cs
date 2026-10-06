using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Menu myMenu = new Menu();
        int response = 0;

        while(response != 5)
        {
            response = myMenu.ProcessMenu();
            switch (response)
            {
                case 1:
                Console.WriteLine("Create");
                    // Call create JournalEntry
                    break;
                case 2:
                    // Call display journal
                    Console.WriteLine("display");
                    break;
                case 3:
                    // Call write to file
                    Console.WriteLine("Write to file");
                    break;
                case 4:
                    // Call read to file
                    Console.WriteLine("read from file");
                    break;
            }
        }
    }
}