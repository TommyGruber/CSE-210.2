using System;
using System.Diagnostics.Contracts;
using System.Reflection.Metadata;

class Program
{
    private static bool user_continue;

    static void Main(string[] args)
    {
        // This is to start the user on the path of writing a prompt.
        Console.WriteLine("Hello Develop03 World!");
        
        // This is where the prompt will generate and save to the journal entry class.
        do
        {
            Console.WriteLine("Would you like to write a journal entry (Y/N): ");
            string user_input = Console.ReadLine();
            bool user_continue = true;
            if (user_input == "Y")
            {
                Console.WriteLine("What is today's date? (Normaly The user wouldn't input this and it'd pull from the computer)");
                string todayDate = Console.ReadLine();


                JournalPromptGenerator journalPrompt = new JournalPromptGenerator();
                string currentPromt = journalPrompt.GenerateRandomPrompt();
                Console.WriteLine(currentPromt);
                string userJournal = Console.ReadLine();

                // This is where the user's journal entery and date is moved into the list.
                // This is a constructor and how it works.
                JournalEntry journalEntry = new JournalEntry(todayDate, currentPromt, userJournal);

                // The user can call a journal from the list.
                JournalList journalList = new JournalList();
                journalList.AddEntry(journalEntry);
                
                user_continue = true; // Continue the loop
            }
            else if (user_input == "N")
            {
                Console.WriteLine("Exitting journal entry program.");
                user_continue = false; // Exit the loop
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter 'Y' or 'N'.");
                user_continue = true; // Continue the loop
            }
        } while (user_continue);

        do
        {
            Console.WriteLine("Would you like to pull up any past entries (Y/N): ");
            string user_input2 = Console.ReadLine();
            bool user_continue2 = true;
            
            if (user_input2 == "Y")
                Console.WriteLine("What date would you like to bring up?");

                user_continue2 = true; // Continue the loop

            else if(user_input2 == "N")
                Console.WriteLine("Exitting program");

                user_continue2 = false; // Exit the loop
            else
                Console.WriteLine("Invalid input");

                user_continue2 = true // Continue the loop

        } while (user_continue2);
    }


}