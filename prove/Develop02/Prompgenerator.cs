using System;
using System.Collections.Generic;

public class PromptGenerator
{
    // List to hold predefined prompts
    private List<string> prompts = new List<string>();

  
    public PromptGenerator()
    {
        StorePrompt(); 
    }

    // Method to store default prompts in the list
    private void StorePrompt()  //Prompts
    {
        prompts.Add("What challenge did I overcome today, and how did I handle it?"); 
        prompts.Add("If I could change one thing about today, what would it be and why?"); 
        prompts.Add("Who did I help today, and how did it make me feel?"); 
        prompts.Add("What new thing did I learn today that surprised me?"); 
        prompts.Add("What was my favorite moment of the day and why?"); 
        prompts.Add("If I could relive one part of today, what would it be and what would I do differently?"); 

    }

    // Method to get a random prompt from the list
    public string GetRandomPrompt()
    {
        Random random = new Random(); 
        int index = random.Next(prompts.Count); 
        return prompts[index]; 
    }
}
