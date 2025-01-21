using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        string letter;
        string sign = "";
        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (percent % 10 >= 7)
        {
            Console.WriteLine("MINUS!");
            Console.WriteLine(percent % 10);

            sign = "+";

        }
        else if (percent % 10 < 3)
        {
            Console.WriteLine("PLUS!");
            Console.WriteLine(percent % 10);
            sign = "-";


        }

        if (percent == 100 || percent == 0)
        {
            sign = "";
        }

        Console.WriteLine($"Your grade is: {letter}{sign}");

        if (percent >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}