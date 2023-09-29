using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks.Dataflow;

public class Job
{
    public String company { get; set; }
    public String job { get; set; }
    public int startYear { get; set; }
    public int endYear { get; set; }

    public void DisplayJobDetails()
    {
        Console.WriteLine(job + " " + "(" + company + ")" + " " + startYear + "-" + endYear);
    }
}