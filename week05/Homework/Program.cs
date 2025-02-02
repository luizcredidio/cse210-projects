using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        MathAssignment mathAssignment = new MathAssignment("7.3", "8-19", "Luiz Credidio", "Fractions");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());

        Console.WriteLine();

        WritingAssignment writingAssignment = new WritingAssignment("The Causes of World War II by Mary Waters", "Luiz Credidio", "European History");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}