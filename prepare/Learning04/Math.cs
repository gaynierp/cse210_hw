class Math : Assingments
{
    private string _textbookSection;
    private string _problems;

    public Math(string name, string topic, string textbook, string problems)
    :base(name, topic)
    {
        _problems=problems;
        _textbookSection=textbook;
    }
    public string GetHomeworkList()
    {
        return $"{_textbookSection} {_problems}";
    }
}