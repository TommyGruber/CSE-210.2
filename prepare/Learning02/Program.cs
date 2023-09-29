using System;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");
        Job job1 = new Job();
        job1.job = "Software Engineer";
        job1.company = "Microsoft";
        job1.startYear = 2019;
        job1.endYear = 2022;

        Job job2 = new Job();
        job2.job = "Manager";
        job2.company = "Apple";
        job2.startYear = 2022;
        job2.endYear = 2023;

        job1.DisplayJobDetails();
        job2.DisplayJobDetails();

        Resume resume1 = new Resume();
        resume1.name = "Allison Rose";
        resume1.jobs = new List<Job>();
        resume1.jobs.Add(job1);
        resume1.jobs.Add(job2);

        resume1.DisplayResumeDetails();
        
    }
}