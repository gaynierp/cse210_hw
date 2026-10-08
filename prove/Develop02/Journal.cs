using System.IO;
class Journal
{
    public void WriteToFile(string filename, string entry)
    {   
        if (!File.Exists(filename)) // I looked this up because I was working on this on my own and couldn't figure out how to get it to find the file.
        {
            File.Create(filename);
        }
        using (StreamWriter outputFile = new StreamWriter (filename))
        {
            {
                outputFile.WriteLine($"{entry}");
            }
        }
    }
    public void ReadFromFile(string file)
    {
        if (!File.Exists(file))
        {
            File.Create(file);
        }
        string[] lines = System.IO.File.ReadAllLines(file);
        foreach(string line in lines)
        {
            Console.WriteLine(line);
        }
    }
    public void DisplayJournal(string entry)
    {
        Console.WriteLine(entry);
    }
}