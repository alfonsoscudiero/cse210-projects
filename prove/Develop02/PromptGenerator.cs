using System;
public class PromptGenerator
{
    public List<string> _prompts = new List<string>
    {
        "Describe a challenge you faced today.",
        "What are you grateful for today?",
        "If you could travel anywhere in the world, where would you go?",
        "What makes you happy?",
        "Five years from now, I will be...",
        "List the top 3 people you admire, and why."
    };
    public Random randomPrompt = new Random();
    // Method to get random prompt from the list
    public string GetRandomPrompt()
    {
        int index = randomPrompt.Next(_prompts.Count);
        return _prompts[index];
    }
}