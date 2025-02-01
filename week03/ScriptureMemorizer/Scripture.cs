using System;

class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    private Random _random = new Random();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        //In Typescript arrays are dynamic, in C# there's a notion of Array with fixed size and List which is similar to Arrays in TS
        //So I had to turn the Array into a list, I know it's a little bit more advanced than what we have here 
        List<string> wordsList = text.Split(" ").ToList();

        foreach (string word in wordsList)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int amountToHide)
    {
        for (int i = 0; i < amountToHide; i++)
        {
            List<Word> wordsStillInDisplay = _words.FindAll(word => !word.isHidden());
            //I got this idea also from TypeScript, the difference is that typescript we use Continue
            if (wordsStillInDisplay.Count == 0) break;

            int randomIndex = _random.Next(0, wordsStillInDisplay.Count);
            wordsStillInDisplay[randomIndex].Hide();
        }
    }

    public string GetDisplayText(Boolean shouldDisplayAll)
    {
        string text = "";
        foreach (Word word in _words)
        {
            if (shouldDisplayAll)
            {
                word.Show();
            }
            text += $" {word.GetDIsplayText()}";
        }
        return $"{_reference.GetDIsplayText()}: {text}";
    }

    public Boolean IsCompletelyHidden()
    {
        return _words.TrueForAll((Word singleWord) => singleWord.isHidden() == true);
    }
}