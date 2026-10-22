using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture myScriptue = new Scripture("moses", 1, 39, 
            "Behold, this is my work and my glory to bring to pass the immortality and eternal life of man.");
        
        myScriptue.ShowScripture();
    }
}