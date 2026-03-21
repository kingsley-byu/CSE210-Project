using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    List<Word> _words = new List<Word>();
    
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string [] parts = text.Split(" ");
        
        foreach (string word in parts)
        {
            Word w1 = new Word(word);
            _words.Add(w1);
        }

    }
    
    public void HideRandomWords(int numberToHide)
    {
        
    }
    public string GetDisplayText()
    {
        
    }

    public bool IsCompletelyHidden()
    {
        
    }
}