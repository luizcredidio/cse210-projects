using System;
//Exceeding Requirements
//I'm presenting a list of scriptures the user can choose from to memorize.

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptures =
        [
            new Scripture(new Reference("Joseph Smith—History", 1, 15, 20), "Joseph Smith saw two Personages, whose brightness and glory defy all description."),
            new Scripture(new Reference("Doctrine and Covenants", 1, 30), "The only true and living church"),
            new Scripture(new Reference("Doctrine and Covenants", 1, 37, 38), "Whether by mine own voice or by the voice of my servants, it is the same")
        ];

        Console.WriteLine("Which scripture do you want to memorize?");
        Console.WriteLine("Type the number and press enter");
        Console.WriteLine();
        Console.WriteLine($"1- {scriptures[0].GetDisplayText(true)}");
        Console.WriteLine($"2- {scriptures[1].GetDisplayText(true)}");
        Console.WriteLine($"3- {scriptures[2].GetDisplayText(true)}");
        Console.WriteLine();

        int scriptureNumber = int.Parse(Console.ReadLine());

        if (scriptureNumber < 1 | scriptureNumber > 3)
        {
            Console.WriteLine("Invalid Selection, run the program again.");
        }

        Scripture selectedScripture = scriptures[scriptureNumber - 1];
        Boolean shouldEnd = false;

        while (shouldEnd == false)
        {
            Console.Clear();
            Console.WriteLine(selectedScripture.GetDisplayText(false));
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            Console.WriteLine();

            string userAction = Console.ReadLine();

            if (userAction == "quit")
            {
                shouldEnd = true;
            }

            if (selectedScripture.IsCompletelyHidden())
            {
                return;
            }

            int numberToHide = new Random().Next(1, 3);
            selectedScripture.HideRandomWords(numberToHide);
        }
    }
}