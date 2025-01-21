using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        Random randomGenerator = new Random();
        int randomNumber = randomGenerator.Next(1, 3);
        //Code for when the user wants to choose the number to guess
        //Console.Write("What is the magic number? ");
        // int magicNumber = int.Parse(Console.ReadLine());
        int guessedNumber = -1000;
        int numberOfGuesses = 0;
        Boolean shouldKeepPlaying = true;
        while (guessedNumber != randomNumber & shouldKeepPlaying)
        {
            Console.Write("What is your guess? ");
            guessedNumber = int.Parse(Console.ReadLine());
            if (randomNumber > guessedNumber)
            {
                numberOfGuesses += 1;
                Console.WriteLine("Higher");
            }
            else if (randomNumber < guessedNumber)
            {
                numberOfGuesses += 1;
                Console.WriteLine("Lower");
            }
            else
            {
                numberOfGuesses += 1;
                Console.WriteLine($"You guessed it! It took you {numberOfGuesses} guesses!");
                Console.WriteLine("GAME OVER, Do you want to keep playing ?");

                string answer = Console.ReadLine();
                if (answer == "no" | answer == "No")
                {
                    Console.WriteLine("Good bye!");
                    shouldKeepPlaying = false;
                }
                else if (answer == "Yes" | answer == "yes")
                {
                    Console.WriteLine("Let's go!");
                    shouldKeepPlaying = true;
                    guessedNumber = -100;
                    numberOfGuesses = 0;
                }
                else
                {
                    Console.WriteLine("Invalid answer!");
                    shouldKeepPlaying = false;
                }
            }
        }


    }
}


