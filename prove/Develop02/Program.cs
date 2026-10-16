using System;
// My Creativity for this assignment was to figure out a way to make the menu disappear on repeated use!
// I used Try/Catch and more if statements to accomplish this!
class Program
{
    static void Main(string[] args)
    {
        Menu myMenu = new Menu();
        int response = 0;
        string fullEntry = "";
        while(response != 5)
        {
            response = myMenu.ProcessMenu();
            switch (response)
            {
                case 1:
                Console.WriteLine("\n\nCreate");
                    // Call create JournalEntry
                    JournalEntry entry = new JournalEntry();
                    string date = entry.GetDate();
                    string prompt = entry.RandomPrompt();
                    Console.WriteLine(prompt);
                    string reader = entry.ReadResponse();
                    fullEntry = fullEntry + "\n\n" + entry.FormatEntry(date, prompt, reader);
                    break;
                case 2:
                    // Call display journal
                    Console.WriteLine("\n\ndisplay");
                    Journal display = new Journal();
                    display.DisplayJournal(fullEntry);
                    break;
                case 3:
                    // Call write to file
                    Console.WriteLine("\n\nWrite to file\nWhat file would you like to save to?");
                    string file = Console.ReadLine();
                    Journal write = new Journal();
                    write.WriteToFile(file, fullEntry);

                    break;
                case 4:
                    // Call read to file
                    Console.WriteLine("\n\nRead from file\nType a file to read from");
                    string fileName = Console.ReadLine();
                    Journal read = new Journal();
                    read.ReadFromFile(fileName);
                    break;
            }
        }
    }
}