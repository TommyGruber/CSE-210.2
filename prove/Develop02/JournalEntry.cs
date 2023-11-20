public class JournalEntry
{
    public string Response { get; set; }
    public string Date { get; set; }
    public string Prompt { get; set; }
    public JournalEntry(string date, string prompt, string response)
    {
        Date = date;
    }
}