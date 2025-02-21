using System;
using System.Collections.Generic;
using System.Threading;

public class ListingActivity : Activity
{
    private List<string> _prompts;

    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
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
        Console.WriteLine("Start listing items. Press enter after each item. When done, just press enter on an empty line.");
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
        Console.WriteLine($"You listed {items.Count} items.");
        DisplayEndMessage();
    }
}
