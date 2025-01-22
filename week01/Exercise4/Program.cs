using System;
using System.Collections.Generic;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("  Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();
        int nextNewNumber = -1;
        float total = 0;
        int largestNumber = 0;
        int smallestPositiveNumber = 0;
        while (nextNewNumber != 0)
        {
            Console.WriteLine("Enter number: ");
            nextNewNumber = int.Parse(Console.ReadLine());
            if (nextNewNumber != 0)
            {
                numbers.Add(nextNewNumber);
                total += nextNewNumber;
                if (nextNewNumber > largestNumber)
                {
                    largestNumber = nextNewNumber;
                }

                if (smallestPositiveNumber == 0 & nextNewNumber > 0)
                {
                    smallestPositiveNumber = nextNewNumber;
                }

                if (nextNewNumber > 0 & nextNewNumber < smallestPositiveNumber)
                {
                    smallestPositiveNumber = nextNewNumber;
                }
            }
        }
        float average = (float)total / (float)numbers.Count;
        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNumber}");
        Console.WriteLine($"The smallest positive number is: {smallestPositiveNumber}");
        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}
