using System;

class Program
{
    static void Main(string[] args)
    {
        string run = "";
        Scripture myScriptue = new Scripture("Moses", 1, 39, 
            "Behold, this is my work and my glory to bring to pass the immortality and eternal life of man.");
        myScriptue.ShowScripture();
        while (run.ToLower() != "quit" && myScriptue.CheckLengthOfList() == false){
            myScriptue.ShowScripture();
            run = Console.ReadLine();
            myScriptue.HideRandomWords();
        }
        myScriptue.ShowScripture();
    }
}