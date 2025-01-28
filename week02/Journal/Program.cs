using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        PromptGenerator generator = new PromptGenerator();
        Journal newEntry = new Journal();
        string filename;
        int i = 0;
        while (i == 0)
            {;
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select from one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do?");
            string input = Console.ReadLine();

            if (input == "1")
            {   
                //generate a new prompt
                generator._random = randomGenerator.Next(0,4);
                generator._DisplayPrompt();
                //get the current time
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();
                //save the entry
                newEntry._entries.Add($"{dateText}: {Console.ReadLine()}");

            }
            else if (input == "2")
            {
                newEntry._displayEntries();
            }
            else if (input == "3")
            {
                Console.WriteLine("What is the filename?");
                filename = Console.ReadLine();
                
            }
            else if (input == "4")
            {
                Console.WriteLine("What is the filename?");
                filename = Console.ReadLine();
                newEntry._filename = filename;
                newEntry._saveEntries();
            }
            else if (input == "5")
            {
                i = 1;
            };
        }
    }
}