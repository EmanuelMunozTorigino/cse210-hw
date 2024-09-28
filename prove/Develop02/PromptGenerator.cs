using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> _prompts = new List<string>();

    public string GetRandomPrompt()
    {

        _prompts = [
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "If I had one thing I could do over today, what would it be?",
        "What would I like to improve tomorrow?",
        "Who or what inspired me today?",
        "What am I grateful for today?",
        "How do I feel right now and Why?",
        "How can I make tomorrow even better than today?",
        "What challenges did i face, and how did I overcome them?",
        "What did I do today to move closer to my goals?"];


        Random random = new Random();

        int index = random.Next(0, _prompts.Count -1);

        string prompt = _prompts[index];

        return prompt;
    }

}

