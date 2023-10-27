using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World! Welcome!");
        string userName = PromptUserName();
        int favoriteNumber = PromptUserNumber();
        int squaredNumber = SquaredNumber(favoriteNumber);
        Console.WriteLine($"{userName}, The suare of your number is {squaredNumber}");
    }
    static string PromptUserName()
    {
        Console.WriteLine("What is your username: ");
        return Console.ReadLine();
    }
    static int PromptUserNumber()
    {
        Console.WriteLine("What is your favorite number?: ");
        return int.Parse(Console.ReadLine());
    }
    static int SquaredNumber(int number)
    {
        return number * number;
    }
}