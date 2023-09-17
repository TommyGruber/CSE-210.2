using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.Write("What is the grade percent do you have? ");
        string input = Console.ReadLine();
        int grade = int.Parse(input);

        if (grade >= 90)
        {
            Console.WriteLine("You have an 'A'. You have an A! Keep up the good work!");
        }
        else if (grade >= 80)
        {
            Console.WriteLine("You have a 'B'. You have a B, thats pretty good! Shoot for an A!");
        }
        else if (grade >= 70)
        {
            Console.WriteLine("You have a 'C'. Youre in the middle, you can get it up to a B! :D");
        }
        else if (grade >= 60)
        {
            Console.WriteLine("You have a 'D'. You are close to failing, you can get your gread up :D");
        }
        else if (grade < 60)
        {
            Console.WriteLine("You have a 'F'. You are failing");
        }
    }
}