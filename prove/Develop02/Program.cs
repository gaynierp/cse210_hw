using System;
// My Creativity for this assignment was to figure out a way to make the menu disappear on repeated use!
// I used Try/Catch and more if statements to accomplish this!
class Program
{
    static void Main(string[] args)
    {
        Menu myMenu = new Menu();
        Journal myJournal = new Journal();
        int response = 0;
        while(response != 5)
        {
            response = myMenu.ProcessMenu();
            switch (response)
            {
                case 1:
                    myJournal.CreateEntry();
                    break;
                case 2:
                    myJournal.DisplayJournal();
                    break;
                case 3:
                    Console.WriteLine("What file would you like to save to?");
                    string filename = Console.ReadLine();
                    myJournal.WriteToFile(filename);
                    break;
                case 4:
                    Console.WriteLine("What file would you like to read from?");
                    filename = Console.ReadLine();
                    myJournal.ReadFromFile(filename);
                    break;
            }
        }
    }
}