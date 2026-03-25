using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    
    
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string [] parts = text.Split(" ");
        
        foreach (string word in parts)
        {
            Word w = new Word(word);
            _words.Add(w);
        }

    }
    
    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        for (int i = 0; i <numberToHide; i++)
        {
            int index = random.Next(_words.Count);
            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
            }
            else
            {
                i--;
            }
                   
        }
            
            
    }
    public string GetDisplayText()
    {
       string result = _reference.GetDisplayText() + "\n";
       foreach (Word word in _words)
        {
            result += word.GetDisplayText() + " ";
        }
        return result;
        
    }

    public bool IsCompletelyHidden()
    {

        foreach (Word word in _words)
        {
           if (!word.IsHidden())
            {
                return false;
            } 
        }
        return true;
    }
    // This method show all text after they have been completely hidden
    public void ShowAllWords()
    {
        foreach (Word word in _words)
        {
            word.Show();
        }
    }
}