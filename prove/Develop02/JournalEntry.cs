class JournalEntry
{
    public string GetDate()
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        return dateText;
    }
    public string RandomPrompt()
    {
        List<string> promptList = new List<string>
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
        Random number = new Random();
        int randomIndex = number.Next(promptList.Count);
        string prompt = promptList[randomIndex];
        return prompt;

    }
    public string ReadResponse()
    {
        string response = Console.ReadLine();
        return response;
    }

    public string FormatEntry(string date, string prompt, string response)
    {
        string entry = $"{date}\n{prompt}\n\n{response}";
        return entry;
    }
}