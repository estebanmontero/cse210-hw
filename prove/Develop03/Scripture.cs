using System;
using System.Collections.Generic;

public class Scripture  // Class new object 
{
    private Reference _reference; // here define a variable that is private 
    private List<Word> _words; // here define a private list that holds words objects  

    // Constructor method
    public Scripture(Reference reference, string text)
    {
        _reference = reference; // Assigns the reference (book, chapter, verse)
        _words = new List<Word>(); // Initializes the list of words

        // Splits the text into individual words and adds each as a Word object
        string[] words = text.Split(' ');
        foreach (string wrd in words)
        {
            _words.Add(new Word(wrd)); // Creates a Word object for each word in the text
        }
    }

    // Method hiderandomwords with int 
    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int hiddenCount = 0;

        // Loop 
        while (hiddenCount < numberToHide)
        {
            int randomIndex = random.Next(_words.Count); 
            Word wordToHide = _words[randomIndex];

            if (!wordToHide._IsHidden()) 
            {
                wordToHide.Hide(); 
                hiddenCount += 1; 
            }
        }
    }

    // Method to display the scripture
    public string GetDisplayText()
    {
        string displayText = "";


        foreach (Word word in _words)
        {
            displayText += word.GetDisplayText() + " "; 
        }

        return $"{_reference.GetDisplayText()}  {displayText.Trim()}"; 
    }

    // Method bool  to check if all words in the scripture are hidden
    public bool IsCompletelyHidden()
    {
     
        foreach (Word word in _words)
        {
            if (!word._IsHidden())
            {
                return false; 
            }
        }
        return true; 
    }
}
