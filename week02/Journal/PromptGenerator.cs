using System;

class PromptGenerator
{
    //this way of creating a list is not chatgpt, it's c# official documentation
    //I wasn't sure if documentation was allowed but I hope it is
    //https://learn.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/tutorials/arrays-and-collections
    private List<string> _prompts =
    [
    "How many times did you loose track of time because of social media?",
    "How many times were you bored today?",
    "What is one thing you gave your best today?",
    "What is one thing you did today that you regret?",
    "If you die tonight, will you be happy with what you have done with you life?",
    "If you could ask yourself from the future one thing, what would that be?",
    "What are three things you will try to achieve tomorrow?",
    "What is the smallest thing you think you can improve before you go to sleep tonight?",
    "If you could choose what to dream with today, what would that be?",
    "Did you drink enough water today?"
    ];

    public string GetRandomPrompt()
    {
        int randomIndex = new Random().Next(0, 10);
        return _prompts[randomIndex];
    }
}