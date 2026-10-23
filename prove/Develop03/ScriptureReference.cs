class ScriptureReference
{
    private string _name;
    private int _chapter;
    private List<int> _verses = new List<int>();
    private string _reference;

    public ScriptureReference(string name, int chapter, int verse)
    {
        _name = name;
        _chapter = chapter;
        _verses.Add(verse); // I looked this up, just how to add something to an array.
        _reference = GetScriptureReference();
    }

    public ScriptureReference(string name, int chapter, int startVerse, int endVerse)
    {
        _name = name;
        _chapter = chapter;
        _verses.Add(startVerse);
        _verses.Add(endVerse);
        _reference = GetScriptureReference();

    }

    public void DisplayScriptureReference()
    {
        GetScriptureReference();
        Console.WriteLine(_reference);
    }
    public string GetScriptureReference()
    {
        if (_verses[0] != _verses[^1])
        {
            return $"{_name} {_chapter}:{_verses[0]}-{_verses[^1]}";
        }
        else {
            return $"{_name} {_chapter}:{_verses[0]}";
        }
    }
}
