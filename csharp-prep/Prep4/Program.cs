using System;
using System.Globalization;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        bool userInput = false;
        List<int> userNumbers = new List<int>();
        do
        {
            Console.WriteLine("Please input a number, when finished enter 0: ");
            int numberInput = int.Parse(Console.ReadLine()); 
            if (numberInput == 0)
            {
                userInput = true;
            }

            else
            {
                userNumbers.Add(numberInput);
            }



        }while (userInput != true);

        // This is the easier ones to find
        int sum = userNumbers.Sum();
        int totalNumbers = userNumbers.Count();
        int average = sum / totalNumbers;

        int largestNumber = int.MinValue;
        
        foreach (int number in userNumbers)
        {
            if (number > largestNumber)
            {
                largestNumber = number;
            }
        }
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The the largest number is: {largestNumber}");

    }
}