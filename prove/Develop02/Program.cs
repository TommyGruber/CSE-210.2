using System;
using System.Diagnostics.Contracts;

class Program
{
    static void Main(string[] args)
    {
        // This is to start the user on the path of writing a prompt.
        Console.WriteLine("Hello Develop03 World!");
        Console.WriteLine("What is today's date? (Normaly The user wouldn't input this and it'd pull from the computer)");
        string todayDate = Console.ReadLine();


        JournalPromptGenerator journalPrompt = new JournalPromptGenerator();
        Console.WriteLine(journalPrompt);
        string userJournal = Console.ReadLine();

        // This is where the user's journal entery and date is moved into the list.

        JournalEntry journalEntry = new JournalEntry();
        journalEntry.Date = todayDate;
        journalEntry.Response = userJournal;

        // The user can call a journal from the list.
        JournalList journalList = new JournalList();
        journalList.AddEntry(journalEntry);



    }


}