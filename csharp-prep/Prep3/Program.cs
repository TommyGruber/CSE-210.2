using System;

class Program
{
    static void Main(string[] args)
    {
        bool numberGuessed = false;
        Random random = new Random();
        int randomNumber = random.Next(1, 11);

        Console.WriteLine("Hello Prep3 World!");

        Console.WriteLine("Guess the number: ");
        do
        {
            Console.WriteLine();
            
            int userGuess = int.Parse(Console.ReadLine());

            if (userGuess == randomNumber)
            {
                Console.WriteLine("You guessed it!");
                numberGuessed = true;
            }
            else if (userGuess > randomNumber)
            {
                Console.WriteLine("Too high, try again.");
            }
            else
            {
                Console.WriteLine("Too low, try again.");
            }

        } while (numberGuessed == false);
    }
}
