using System;

class Entry
{
    public string _dateText;
    public string _promptText;
    public string _entryText;

    public string GetFormattedEntryText()
    {
        return $"{_entryText}";

    }
    public string GetFormattedEntryPromptAndDate()
    {
        return $"Date: {_dateText} - Prompt: {_promptText}";
    }
    public void DisplayEntry()
    {
        Console.WriteLine($"{GetFormattedEntryPromptAndDate()}");
        Console.WriteLine($"{GetFormattedEntryText()}");
    }
}