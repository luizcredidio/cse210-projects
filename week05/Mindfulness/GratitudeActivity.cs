using System;
using System.Collections.Generic;
using System.Threading;

public class GratitudeActivity : Activity
{
    private List<string> _prompts;

    public GratitudeActivity() : base("Gratitude", "This activity will help you practice being greatfull by asking you to reflect on the positive aspects of your life.")
    {
        _prompts = new List<string>
        {
            "List things you are grateful for in your personal life.",
            "List things that brought you joy recently.",
            "List people you are thankful to have in your life."
        };
    }

    public void Run()
    {
        DisplayStartMessage();
        Random rnd = new Random();
        int promptIndex = rnd.Next(_prompts.Count);
        Console.WriteLine(_prompts[promptIndex]);
        Console.WriteLine("You have a few seconds to think about it...");
        ShowCountdown(5);
        Console.WriteLine();
        Console.WriteLine("Start listing gratitude items. Press enter after each item. When done, just press enter on an empty line.");
        List<string> items = new List<string>();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            if (Console.KeyAvailable)
            {
                string input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    break;
                }
                items.Add(input);
            }
            else
            {
                Thread.Sleep(100);
            }
        }
        Console.WriteLine($"You listed {items.Count} gratitude items.");
        DisplayEndMessage();
    }
}
