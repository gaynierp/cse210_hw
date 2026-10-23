class Scripture
{   
    private List<Word> _words;
    private ScriptureReference _reference;
    private List<int> _indexNumberList = new List<int>();

    public Scripture(string name, int chapter, int verse, string text)
    {
        _words = ConvertToWordList(text);
        _reference = new ScriptureReference(name, chapter, verse);
    }
    public Scripture(string name, int chapter, int startVerse, int endVerse, string text)
    {
        _words = ConvertToWordList(text);
        ScriptureReference reference = new ScriptureReference(name, chapter, startVerse, endVerse);
        _reference = reference;
    }

    public void ShowScripture()
    {
        Console.Clear();
        Console.WriteLine(_reference.GetScriptureReference());
        foreach(Word word in _words)
        {
            word.Display();
        }
    }
    private List<Word> ConvertToWordList(string text)
    {
        List<Word> tempWordList = new List<Word>();
        string[] tempWords = text.Split(' ');
        foreach(string w in tempWords)
        {
            Word tempWord = new Word(w);
            tempWordList.Add(tempWord);
        }
        return tempWordList;
    }

    public void HideRandomWords()
    {
        Random number = new Random();
        for (int i = 0; i <= 3; i++){
            int index = number.Next(0, _words.Count);
            if (CheckLengthOfList()== false){

                if (_indexNumberList.Contains(index))
                {
                    i--;
                }
                else
                {
                    _indexNumberList.Add(index);
                    _words[index].Hide();
                }
            }
            else
            {
                break;
            }
        }
    }
        public bool CheckLengthOfList()
    {
        if (_words.Count <= _indexNumberList.Count)
        {
            return true;
        }
        return false;
    }

}