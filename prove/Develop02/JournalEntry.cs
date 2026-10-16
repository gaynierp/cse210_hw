class JournalEntry
{
    private string _date;
    private string _prompt;
    private string _response;


    public void DisplayJournalEntry()
    {
        Console.WriteLine($"{_date}, {_prompt}");
        Console.WriteLine(_response);
    }

    public void CreateJournalEntry()
    {
        string [] prompts =
        {
            "What did you do today?", 
            "What were you looking forward to today?", 
            "Did anything make you happy today?", 
            "Who did you make smile today?", 
            "Who made you smile today?", 
            "What adivce would you give yourself for tomorrow?", 
            "What did you eat today?", 
            "What could you have done better today?"
        };
        _date = DateTime.Now.ToString();
        int number = new Random().Next(1, 8);
        _prompt = prompts[number];
        Console.Write($"{_prompt}: ");
        _response = Console.ReadLine();
    }

    public string FormatEntry()
    {
        return $"{_date}#{_prompt}#{_response}";
    }


}