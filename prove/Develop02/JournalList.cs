public class JournalList
{
    private Dictionary<string, JournalEntry> entries = new Dictionary<string, JournalEntry>();

    public Dictionary<string, JournalEntry> Entries
    {
        get { return entries; }
    }

    // Simplified method to add a new entry
    public void AddEntry(JournalEntry entry)
    {
        entries.Add(entry.Date, entry);
    }

    // Method to get an entry by date
    public JournalEntry GetEntryByDate(string date)
    {
        if (entries.ContainsKey(date))
        {
            return entries[date];
        }
        else
        {
            Console.WriteLine("Entry not found for the given date.");
            return null;
        }
    }
}