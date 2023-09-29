public class Resume
{
    public String name { get; set; }
    public List<Job> jobs { get; set; }

    public void DisplayResumeDetails()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Jobs:");

        foreach (Job job in jobs)
        {
            job.DisplayJobDetails();
        }
    }
}