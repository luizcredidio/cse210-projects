using System;
//This does not have copy paste, c# is just very similar to JS
//https://www.linkedin.com/in/luizcredidio/
class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator prompts = new PromptGenerator();
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
                string _newPrompt = prompts.GetRandomPrompt();
                Console.WriteLine(_newPrompt);
                Console.WriteLine(">   ");
                string _newEntryText = Console.ReadLine();
                //Object initializers
                //https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/how-to-initialize-objects-by-using-an-object-initializer
                journal.AddEntry(DateTime.Now.ToShortDateString(), _newPrompt, _newEntryText);
            }
            else if (choice == "2")
            {
                journal.DisplayAllEntries();
            }
            else if (choice == "3")
            {
                Console.WriteLine("What is the filename?");
                Console.WriteLine(">   ");
                string _fileName = Console.ReadLine();
                journal.LoadFromFIle(_fileName);
            }
            else if (choice == "4")
            {
                Console.WriteLine("What is the filename?");
                Console.WriteLine(">   ");
                string _fileName = Console.ReadLine();
                journal.SaveToFile(_fileName);
            }
            else if (choice == "5")
            {
                option = choice;
            }
        }
    }
}