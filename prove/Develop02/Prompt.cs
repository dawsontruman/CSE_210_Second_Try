using System;

public class Prompt
{
    List<string> _prompts = [
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        // first five are examples from the assignment document
        "Describe the most challenging situation I faced today, and how I overcame it."];
    public string GenerateRandomPrompt()
    {
        Random random = new Random();
        int randNum = random.Next(0,_prompts.Count());
        string prompt = _prompts[randNum];
        return prompt;
    }
}