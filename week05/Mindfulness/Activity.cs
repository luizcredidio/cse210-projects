using System;
using System.Threading;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void SetDuration()
    {
        Console.Write("Enter duration in seconds: ");
        int duration;
        while (!int.TryParse(Console.ReadLine(), out duration))
        {
            Console.Write("Please enter a valid number: ");
        }
        _duration = duration;
    }

    public void DisplayStartMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine(_description);
        SetDuration();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
    }

    public void DisplayEndMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!");
        ShowSpinner(3);
        Console.WriteLine($"You have completed the {_name} Activity for {_duration} seconds.");
        ShowSpinner(3);
    }

    protected void ShowSpinner(int seconds)
    {
        int totalMilliseconds = seconds * 1000;
        int interval = 250;
        int spinnerCount = totalMilliseconds / interval;
        string[] spinner = { "|", "/", "-", "\\" };
        for (int i = 0; i < spinnerCount; i++)
        {
            Console.Write(spinner[i % spinner.Length]);
            Thread.Sleep(interval);
            Console.Write("\b \b");
        }
    }

    protected void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}
