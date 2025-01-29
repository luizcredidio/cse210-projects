using System;
//I see now that I didn't add the comment explaining how i exceeded the requirements
//I did that by saving the entries in JSON format
//So when you save the file you shoudl save it as json, filename.json, and load as json as well

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        string option = "";
        while (option != "5")
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do?");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                string newPrompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine(newPrompt);
                Console.WriteLine(">   ");
                string newEntryText = Console.ReadLine();
                //Object initializers
                //https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/how-to-initialize-objects-by-using-an-object-initializer
                journal.AddEntry(DateTime.Now.ToShortDateString(), newPrompt, newEntryText);
            }
            else if (choice == "2")
            {
                journal.DisplayAllEntries();
            }
            else if (choice == "3")
            {
                Console.WriteLine("What is the filename?");
                Console.WriteLine(">   ");
                string fileName = Console.ReadLine();
                journal.LoadFromFIle(fileName);
            }
            else if (choice == "4")
            {
                Console.WriteLine("What is the filename?");
                Console.WriteLine(">   ");
                string fileName = Console.ReadLine();
                journal.SaveToFile(fileName);
            }
            else if (choice == "5")
            {
                option = choice;
            }
        }
    }
}