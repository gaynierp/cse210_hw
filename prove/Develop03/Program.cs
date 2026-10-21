using System;

class Program
{
    static void Main(string[] args)
    {
        Word myWord = new Word("Brother");
        myWord.Display();
        myWord.Hide();
        myWord.Display();
    }
}