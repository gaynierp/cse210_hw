class Assingments
{
    private string _studentName;
    private string _topic;

    public Assingments(string name, string topic)
    {
        _studentName=name;
        _topic=topic;
    }
    public string GetSummary()
    {
        return $"{_studentName} {_topic}";
    }
}