using System.Security.Cryptography.X509Certificates;

class Menu
{
string hide = "";
    public int ProcessMenu()
    {
        int input = 0;
        while (input< 1 || input>6)
        {
        if (hide != "hide")
            {
            Console.WriteLine("\n\nWelcome to the Journal Program.");
            Console.WriteLine("Create, Display, Save, or Read Journal Entries.");
            Console.WriteLine("1. Create new Journal Entry");
            Console.WriteLine("2. Display all journal entries.");
            Console.WriteLine("3. Save journal to a file");
            Console.WriteLine("4. Read Journal from a file");
            Console.WriteLine("5. Quit");
            Console.WriteLine("6. Extra options");
            Console.Write("> ");
            try
            {
                input = int.Parse(Console.ReadLine());
                if(input == 6)
                {
                    Console.WriteLine("The extra options are to make the menu appear and disappear. To make it disappear type \"hide +Enter\" 2 times. To make it appear type \"show + Enter\" 2 times");
                }

            }
            catch
            {
                Console.Write("> ");
                hide = Console.ReadLine();
                Console.WriteLine("You have hidden the Menu. Type \'show\' to show it again");
            }

            }
        else if (hide == "hide")
        {
            Console.Write("> ");
            try 
            {
                input = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.Write("> ");
                hide = Console.ReadLine();
            }
        }
        }
        return input;
    }
}