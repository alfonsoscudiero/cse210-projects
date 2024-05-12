using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = CreateWordList(text);
    }

    private List<Word> CreateWordList(string text)
    {
        // Split the text into words and create Word objects for each word
        var words = text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        return words.Select(word => new Word(word)).ToList();
    }

    public string GetDisplayText()
    {
        // Combine the reference and the display text of all words
        var displayText = _reference.GetDisplayText() + " ";
        displayText += string.Join(" ", _words.Select(word => word.GetDisplayText()));
        return displayText;
    }

    public void HideRandomWords(int numberToHide)
    {
        var random = new Random();
        var visibleWordIndexes = _words
            .Select((word, index) => new { Word = word, Index = index })
            .Where(item => !item.Word.IsHidden())
            .Select(item => item.Index)
            .ToList();

        // Shuffle the visible word indexes
        var shuffledIndexes = visibleWordIndexes.OrderBy(x => random.Next()).ToList();

        // Determine the number of words to hide based on the difficulty level
        int wordsToHide = Math.Min(numberToHide, shuffledIndexes.Count);

        // Hide words at the shuffled indexes
        for (int i = 0; i < wordsToHide; i++)
        {
            _words[shuffledIndexes[i]].Hide();
        }

    }


    public bool IsCompletelyHidden()
    {
        // Check if all words in the scripture are hidden
        return _words.All(word => word.IsHidden());
    }
}
