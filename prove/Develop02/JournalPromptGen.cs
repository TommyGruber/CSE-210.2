using System;

public class JournalPromptGenerator
{
    public string GenerateRandomPrompt()
    {
        Random random = new Random();
        int randomNumber = random.Next(1, 6);
        string prompt = "";

        switch (randomNumber)
        {
            case 1:
                prompt = "Who was the most interesting person I interacted with today? ";
                break;
            case 2:
                prompt = "What was the best part of my day? ";
                break;
            case 3:
                prompt = "How did I see the hand of the Lord in my life today? ";
                break;
            case 4:
                prompt = "What was the strongest emotion I felt today? ";
                break;
            case 5:
                prompt = "If I had one thing I could do over today, what would it be? ";
                break;
            default:
                prompt = "Error";
                break;
        }

        return prompt;
    }
}
